using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/******************************
** 作者： 周永丰
** 变更时间： 2011-8-26
** 引用程序集
** ORM、BLL、Rule
******************************/

/******************************
** 作者： 周永丰
** 变更时间： 2011-8-26
** 命名空间
******************************/
using System.Text.RegularExpressions;
using ORM;
using BLL;
using Rule;
/// <summary>
///FuHai 的摘要说明
/// </summary>
public class FilterFuHai
{
    public FilterFuHai()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }


    /******************************
    ** 作者： 周永丰
    ** 变更时间： 2011-8-26
    ******************************/
    #region###加载富海人才网的数据
    public static void Load()
    {
        int count = RuleFuHai.PageCount / RuleFuHai.PageSize;
        for (int j = count; j > 1; j--)
        {
            string html = RuleFuHai.GetHtmlString(j);
            /** 一次匹配 **/
            Regex re = new Regex("<td width=\"120\" id=\"keyName\">(?:\\s|\\S)*?</td>(?:\\s|\\S)*?</td>(?:\\s|\\S)*?</td>(?:\\s|\\S)*?</td>(?:\\s|\\S)*?</td>(?:\\s|\\S)*?</td>", RegexOptions.None);
            MatchCollection mc = re.Matches(html);

            /** 连接一次匹配后的字符串 **/
            string str = null;
            foreach (Match ma in mc)
            {
                str += ma.Groups[0].Value;
            }

            /** 二次匹配 **/
            re = new Regex("<td width=\"226\" id=\"keyName\">(?:\\s|\\S)*?<a class=\"a_font_black\" target=\"_blank\" href=\"(?<pos_companyurl>(?:\\s|\\S)*?)\">(?<pos_company>(?:\\s|\\S)*?)</a>(?:\\s|\\S)*?<td width=\"189\">(?<pos_address>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td width=\"60\">(?<pos_degree>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td width=\"60\">(?<pos_workexprience>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td width=\"70\">(?<pos_time>(?:\\s|\\S)*?)</td>", RegexOptions.None);
            mc = re.Matches(str);

            /** 一个装载数据的容器List<position> **/
            List<fuhaiposition> postion_data = new List<fuhaiposition>();
            fuhaiposition tem = null;

            /** 记录匹配的“公司”、“地区”、“学历”、“工作经验”、“时间” **/
            foreach (Match ma in mc)
            {
                tem = new fuhaiposition();
                tem.pos_companyurl = ma.Groups["pos_companyurl"].Value.Trim();
                tem.pos_company = ma.Groups["pos_company"].Value.Trim();
                tem.pos_address = ma.Groups["pos_address"].Value.Trim();
                tem.pos_degree = ma.Groups["pos_degree"].Value.Trim();
                tem.pos_workexperience = ma.Groups["pos_workexprience"].Value.Trim();
                tem.pos_time = Convert.ToDateTime(ma.Groups["pos_time"].Value.Trim());
                tem.pos_fromurl = "http://www.jobbaidu.com/";
                tem.pos_from = "富海人才网";
                postion_data.Add(tem);
            }


            re = new Regex("<td width=\"120\" id=\"keyName\">(?:\\s|\\S)*?<a class=\"a_font_black\" target=\"_blank\" href=\"(?<pos_positionurl>(?:\\s|\\S)*?)\">(?<pos_position>(?:\\s|\\S)*?)[<img*](?:\\s|\\S)*?</a>", RegexOptions.None);
            mc = re.Matches(str);

            /** 记录对应匹配的“职位”**/
            int i = 0;
            foreach (Match ma in mc)
            {
                postion_data[i].pos_position = ma.Groups["pos_position"].Value.Trim();
                postion_data[i].pos_positionurl = ma.Groups["pos_positionurl"].Value.Trim();
                i++;
            }

            /** 插入数据库 **/
            foreach (fuhaiposition obj in postion_data)
            {
                using (BLLFuHai a = new BLLFuHai())
                {
                    if (a.Select_Position_FuHai(obj.pos_positionurl))
                        continue;
                    else
                    {
                        if (!a.Insert_Position_FuHai(obj))
                            Util.MessageBox.ShowMessage(a.error);
                    }
                }
            }
        }
    }
    #endregion
}
