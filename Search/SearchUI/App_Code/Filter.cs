using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/******************************
** 作者： 周永丰
** 变更时间： 2011-9-19
** 引用程序集
** ORM、BLL、Rule
******************************/

/******************************
** 作者： 周永丰
** 变更时间： 2011-9-19
** 命名空间
******************************/
using System.Text.RegularExpressions;
using ORM;
using BLL;
using Rule;
/// <summary>
///Filter 的摘要说明
/// </summary>
public class Filter
{
    public Filter()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }


    /******************************
    ** 作者： 周永丰
    ** 变更时间： 2011-9-19
    ******************************/
    #region###加载聚能人才网的数据
    public static void Load_JuNeng()
    {
        /** 获取所有信息 **/
        string html = Rule.RuleJuNeng.GetHtmlString();

        /** 一个装载数据的容器List<position> **/
        List<position> postion_data = new List<position>();
        position tem = null;

        /** 将数据匹配出来 **/
        Regex re = new Regex("<td width=\"200px\"><a href=\"(?<pos_positionurl>(?:\\s|\\S)*?)\">(?<pos_position>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td><a href=\"(?<pos_companyurl>(?:\\s|\\S)*?)\">(?<pos_company>(?:\\s|\\S)*?)</a></td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_address>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_degree>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_workexperience>[\\w]*?)</td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_time>(?:\\s|\\S)*?)</td>", RegexOptions.None);
        MatchCollection mc = re.Matches(html);
        foreach (Match ma in mc)
        {
            tem = new position();
            tem.pos_position = ma.Groups["pos_position"].Value.Trim();
            tem.pos_positionurl = ma.Groups["pos_positionurl"].Value.Trim();
            tem.pos_companyurl = ma.Groups["pos_companyurl"].Value.Trim();
            tem.pos_company = ma.Groups["pos_company"].Value.Trim();
            tem.pos_address = ma.Groups["pos_address"].Value.Trim();
            tem.pos_degree = ma.Groups["pos_degree"].Value.Trim();
            tem.pos_workexperience = ma.Groups["pos_workexperience"].Value.Trim();
            tem.pos_time = Convert.ToDateTime(ma.Groups["pos_time"].Value.Trim());
            tem.pos_fromurl = "http://www.jnjobs.cn/";
            tem.pos_from = "聚能人才网";
            postion_data.Add(tem);
        }

        /** 插入数据库 **/
        foreach (position obj in postion_data)
        {
            using (BLLPosition a = new BLLPosition())
            {
                if (a.Select_Position(obj.pos_positionurl))
                    continue;
                else
                {
                    if (!a.Insert_Position(obj))
                        Util.MessageBox.ShowMessage(a.error);
                }
            }
        }
        return;
    }
    #endregion

    /// <summary>
    /// 分页为20页
    /// </summary>
    public static int count = 20;

    /******************************
    ** 作者： 周永丰
    ** 变更时间： 2011-9-19
    ******************************/
    #region###加载百度招聘的数据
    public static void Load_BaiduHuiZhou()
    {
        /** 一个装载数据的容器List<position> **/
        List<position> postion_data = new List<position>();
        position tem = null;
        for (int j = count; j > 1; j--)
        {
            string html = Rule.RuleBaiduHuiZhou.GetHtmlString(j - 1);
            //string html = Rule.RuleBaiduHuiZhou.GetHtmlString(0);
            /** 将数据匹配出来 **/
            Regex re = new Regex("class=title><a name=job_title(?:\\s|\\S)*?href=\"(?<pos_positionurl>(?:\\s|\\S)*?)\" target=_blank>(?<pos_position>(?:\\s|\\S)*?)</a><br><span class=job_attr>学历:(?<pos_degree>(?:\\s|\\S)*?)</span><span class=job_attr>经验:(?<pos_workexperience>(?:\\s|\\S)*?)</span><span class=job_attr>薪酬:(?<pos_salary>(?:\\s|\\S)*?)</span></td><td>(?<pos_company>(?:\\s|\\S)*?)</td><td>(?<pos_address>(?:\\s|\\S)*?)</td><td>(?<pos_time>(?:\\s|\\S)*?)</td><td><a href=\"(?<pos_fromurl>(?:\\s|\\S)*?)\" target=_blank class=jobsite>(?<pos_from>(?:\\s|\\S)*?)</a></td></tr>", RegexOptions.None);
            MatchCollection mc = re.Matches(html);
            foreach (Match ma in mc)
            {
                tem = new position();
                tem.pos_position = ma.Groups["pos_position"].Value.Trim().Replace("<em>", String.Empty).Replace("</em>", String.Empty);
                tem.pos_positionurl = ma.Groups["pos_positionurl"].Value.Trim();
                tem.pos_companyurl = ma.Groups["pos_companyurl"].Value.Trim();

                tem.pos_company = ma.Groups["pos_company"].Value.Trim().Replace("<em>", String.Empty).Replace("</em>", String.Empty);


                tem.pos_address = ma.Groups["pos_address"].Value.Trim().Replace("<em>", String.Empty).Replace("</em>", String.Empty);

                tem.pos_salary = ma.Groups["pos_salary"].Value.Trim();

                tem.pos_degree = ma.Groups["pos_degree"].Value.Trim();
                tem.pos_workexperience = ma.Groups["pos_workexperience"].Value.Trim();
                tem.pos_time = Convert.ToDateTime(ma.Groups["pos_time"].Value.Trim());
                tem.pos_fromurl = ma.Groups["pos_fromurl"].Value;
                tem.pos_from = ma.Groups["pos_from"].Value.Trim();
                postion_data.Add(tem);
            }
        }


        /** 插入数据库 **/
        foreach (position obj in postion_data)
        {
            using (BLLPosition a = new BLLPosition())
            {
                if (a.Select_Position(obj.pos_positionurl))
                    continue;
                else
                {
                    if (!a.Insert_Position(obj))
                        Util.MessageBox.ShowMessage(a.error);
                }
            }
        }
        return;
    }
    #endregion

    /******************************
    ** 作者： 周永丰
    ** 变更时间： 2011-9-19
    ******************************/
    #region###加载富海人才网的数据
    public static void Load_FuHai()
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
            List<position> postion_data = new List<position>();
            position tem = null;

            /** 记录匹配的“公司”、“地区”、“学历”、“工作经验”、“时间” **/
            foreach (Match ma in mc)
            {
                tem = new position();
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
            foreach (position obj in postion_data)
            {
                using (BLLPosition a = new BLLPosition())
                {
                    if (a.Select_Position(obj.pos_positionurl))
                        continue;
                    else
                    {
                        if (!a.Insert_Position(obj))
                            Util.MessageBox.ShowMessage(a.error);
                    }
                }
            }
        }
    }
    #endregion
}
