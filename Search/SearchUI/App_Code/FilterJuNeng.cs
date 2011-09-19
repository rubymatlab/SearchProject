using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/******************************
** 作者： 周永丰
** 变更时间： 2011-9-1
** 引用程序集
** ORM、BLL、Rule
******************************/

/******************************
** 作者： 周永丰
** 变更时间： 2011-9-1
** 命名空间
******************************/
using System.Text.RegularExpressions;
using ORM;
using BLL;
using Rule;
/// <summary>
///JuNeng 的摘要说明
/// </summary>
public class FilterJuNeng
{
    public FilterJuNeng()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    /******************************
    ** 作者： 周永丰
    ** 变更时间： 2011-9-1
    ******************************/
    #region###加载聚能人才网的数据
    public static void Load()
    {
        /** 获取所有信息 **/
        string html = Rule.RuleJuNeng.GetHtmlString();

        /** 一个装载数据的容器List<position> **/
        List<junengposition> postion_data = new List<junengposition>();
        junengposition tem = null;

        /** 将数据匹配出来 **/
        Regex re = new Regex("<td width=\"200px\"><a href=\"(?<pos_positionurl>(?:\\s|\\S)*?)\">(?<pos_position>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td><a href=\"(?<pos_companyurl>(?:\\s|\\S)*?)\">(?<pos_company>(?:\\s|\\S)*?)</a></td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_address>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_degree>(?:\\s|\\S)*?)</td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_workexperience>[\\w]*?)</td>(?:\\s|\\S)*?<td width=\"100px\">(?<pos_time>(?:\\s|\\S)*?)</td>", RegexOptions.None); 
        MatchCollection mc = re.Matches(html);
        foreach (Match ma in mc)
        {
            tem = new junengposition();
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
        foreach (junengposition obj in postion_data)
        {
            using (BLLJuNeng a = new BLLJuNeng())
            {
                if (a.Select_Position_JuNeng(obj.pos_positionurl))
                    continue;
                else
                {
                    //a.Insert_Position_JuNeng(obj);
                    if (!a.Insert_Position_JuNeng(obj))
                        Util.MessageBox.ShowMessage(a.error);
                }
            }
        }
        return;
    }
    #endregion
}
