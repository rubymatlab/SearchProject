using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rule
{
    /// <summary>
    /// 百度惠州招聘
    /// </summary>
    public class RuleBaiduHuiZhou
    {
        /// <summary>
        /// 每页40条记录
        /// </summary>
        public static int pageSize = 40;
        /// <summary>
        /// 获取html源代码
        /// </summary>
        /// <param name="start">从第0、1、2、3、4、5....10页开始</param>
        /// <returns></returns>
        public static string GetHtmlString(int start)
        {
            string url = "http://open.baidu.com/zhaopin/s?wd=%BB%DD%D6%DD%D5%D0%C6%B8&pn="+start*pageSize+"&tn=baiduzhaopin&rn="+pageSize;
            string str = Util.CatchHTML.GetHTML(url, "gb2312");
            return str;
        }

    }
}
