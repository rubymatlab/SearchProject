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
** 变更时间： 2011-8-26
** 命名空间
******************************/
using System.Text.RegularExpressions;
using ORM;
using BLL;
using Rule;
/// <summary>
///FilterBaiduHuiZhou 的摘要说明
/// </summary>
public class FilterBaiduHuiZhou
{
    public FilterBaiduHuiZhou()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// 分页为20页
    /// </summary>
    public static int count = 20;

    /******************************
    ** 作者： 周永丰
    ** 变更时间： 2011-9-19
    ******************************/
    #region###加载聚能人才网的数据
    public static void Load()
    {
        /** 一个装载数据的容器List<baiduhuizhou> **/
        List<baiduhuizhou> postion_data = new List<baiduhuizhou>();
        baiduhuizhou tem = null;
        for (int j = count; j > 1; j--)
        {
            string html = Rule.RuleBaiduHuiZhou.GetHtmlString(j - 1);
            //string html = Rule.RuleBaiduHuiZhou.GetHtmlString(0);
            /** 将数据匹配出来 **/
            Regex re = new Regex("class=title><a name=job_title(?:\\s|\\S)*?href=\"(?<pos_positionurl>(?:\\s|\\S)*?)\" target=_blank>(?<pos_position>(?:\\s|\\S)*?)</a><br><span class=job_attr>学历:(?<pos_degree>(?:\\s|\\S)*?)</span><span class=job_attr>经验:(?<pos_workexperience>(?:\\s|\\S)*?)</span><span class=job_attr>薪酬:(?<pos_salary>(?:\\s|\\S)*?)</span></td><td>(?<pos_company>(?:\\s|\\S)*?)</td><td>(?<pos_address>(?:\\s|\\S)*?)</td><td>(?<pos_time>(?:\\s|\\S)*?)</td><td><a href=\"(?<pos_fromurl>(?:\\s|\\S)*?)\" target=_blank class=jobsite>(?<pos_from>(?:\\s|\\S)*?)</a></td></tr>", RegexOptions.None);
            MatchCollection mc = re.Matches(html);
            foreach (Match ma in mc)
            {
                tem = new baiduhuizhou();
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
        foreach (baiduhuizhou obj in postion_data)
        {
            using (BLLBaiduHuiZhou a = new BLLBaiduHuiZhou())
            {
                if (a.Select_Position_BaiduHuiZhou(obj.pos_positionurl))
                    continue;
                else
                {
                    //a.Insert_Position_BaiduHuiZhou(obj);
                    if (!a.Insert_Position_BaiduHuiZhou(obj))
                        Util.MessageBox.ShowMessage(a.error);
                }
            }
        }
        return;
    }
    #endregion
}
