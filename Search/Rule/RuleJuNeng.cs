using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rule
{
    /// <summary>
    /// 聚能人才网规则
    /// </summary>
    public class RuleJuNeng
    {
        /// <summary>
        /// 取数据
        /// </summary>
        public static int limit = 1000;

        /// <summary>
        /// 获取网页
        /// </summary>
        /// <returns></returns>
        public static string GetHtmlString()
        {
            string url = "http://www.jnjobs.cn/Search/JobsList.aspx?key=&keytype=&workarea=&jobpost=&industry=&starteducation=10&endeducation=70&stratworkexperience=01&endworkexperience=13&age=16&sex=&iseducationnull=False&isworkexperiencenull=False&isagenull=False&showno=" + limit;
            string str= Util.CatchHTML.GetHTML(url, "utf-8");
            return str;
        }
    }
}
