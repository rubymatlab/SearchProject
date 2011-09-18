using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Rule
{
    /// <summary>
    /// 富海人才网规则
    /// </summary>
    public class RuleFuHai
    {
        /**
     __checkbox_searcher.degNoLimit	true
     __checkbox_searcher.workNoLimit	true
     jobKeyWord	
  * 当前分页
     page.currentPage	4
  * 分页显示
     page.pageSize	20
  * 记录总数
     page.totalCount	1000
     refString	
     searcher.degNoLimit	true
     searcher.degree1	1
     searcher.degree2	1
     searcher.jobAge	0
     searcher.jobCalling1	0
     searcher.jobCalling2	0
     searcher.jobCalling3	0
     searcher.jobFun	
     searcher.jobFunction	
     searcher.jobFunction1	0
     searcher.jobFunction2	0
     searcher.jobFunction3	0
     searcher.jobGender	0
     searcher.jobInd	
     searcher.jobIndustry	
     searcher.jobLocal	
     searcher.jobLocation	
     searcher.jobLocation1	0
     searcher.jobLocation2	0
     searcher.jobLocation3	0
     searcher.jobOrder	1
     searcher.jobPostDate	1
     searcher.jobSalary	0
     searcher.keyWord	
     searcher.keyWordType	1
     searcher.workNoLimit	true
     searcher.workYear1	1
     searcher.workYear2	1
  **/

        /// <summary>
        /// 富海人才网
        /// </summary>
        private static string FuHaiURL = "http://www.jobbaidu.com/Commons/ListPosition!list.shtml";
        /// <summary>
        /// 最大记录数
        /// </summary>
        public static int PageCount = 1000;
        /// <summary>
        /// 分页记录
        /// </summary>
        public static int PageSize = 20;
        /// <summary>
        /// 富海人才网的编码
        /// </summary>
        private static string encoding = "utf-8";
        /// <summary>
        /// form表单的提交模式
        /// </summary>
        private static string form = "application/x-www-form-urlencoded;";
        /// <summary>
        /// 提交方式是Post
        /// </summary>
        private static string method = "POST";
        /// <summary>
        /// 获取一页的代码
        /// </summary>
        /// <param name="start">第1、2、3、4...、50页</param>
        /// <returns></returns>
        public static string GetHtmlString(int start)
        {
            /** 获取传送参数 **/
            string param = String.Format("searcher.jobFunction1=0&searcher.jobFunction2=0&searcher.jobFunction3=0&searcher.jobLocation1=0&searcher.jobLocation2=0&searcher.jobLocation3=0&searcher.jobCalling1=0&searcher.jobCalling2=0&searcher.jobCalling3=0&refString=&searcher.keyWord=&jobKeyWord=&searcher.keyWordType=1&searcher.degree1=1&searcher.degree2=6&__checkbox_searcher.degNoLimit=true&searcher.jobLocal=&searcher.jobLocation=&searcher.workYear1=1&searcher.workYear2=13&__checkbox_searcher.workNoLimit=true&searcher.jobFun=&searcher.jobFunction=&searcher.jobAge=0&searcher.jobGender=0&searcher.jobInd=&searcher.jobIndustry=&searcher.jobOrder=1&searcher.jobSalary=0&searcher.jobPostDate=0&page.pageSize={1}&page.currentPage={0}&page.totalCount={2}",
                start, PageSize, PageCount);
            string str = Util.CatchHTML.PostHTML(FuHaiURL, param, method, form, encoding);
            return str;
        }
    }
}
