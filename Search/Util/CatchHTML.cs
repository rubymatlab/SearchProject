using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/******************************
** 作者： 周永丰
** 变更时间： 2011-8-24
** 命名空间
******************************/
using System.Net;
using System.IO;

namespace Util
{
    public class CatchHTML
    {


        /// <summary>
        /// Get方法获取网页源码
        /// </summary>
        /// <param name="url">网页url路径</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>字符串</returns>
        public static string GetHTML(string url, string encoding)
        {
            WebClient web = new WebClient();
            byte[] buffer = web.DownloadData(url);
            return Encoding.GetEncoding(encoding).GetString(buffer);
        }

        /// <summary>
        /// Post方法获取网页源码
        /// </summary>
        /// <param name="url">网页url路径</param>
        /// <param name="param">传送参数</param>
        /// <param name="method">提交方法Get或者是Post</param>
        /// <param name="contentType">提交类型</param>
        /// <param name="encoding">编码方式</param>
        /// <returns>字符串</returns>
        public static string PostHTML(string url,string param,string method,string contentType,string encoding)
        {
            Encoding myEncoding = Encoding.GetEncoding(encoding);
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(param);
            /** 获取url **/
            WebRequest req = WebRequest.Create(url);
            /** Post **/
            req.Method = method;
            /** from表单提交 **/
            req.ContentType = contentType;
            /** 获取字符串长度 **/
            req.ContentLength = bs.Length;
            Stream reqStream = req.GetRequestStream();
            /** 发送数据 **/
            reqStream.Write(bs, 0, bs.Length);
            reqStream.Close();

            WebResponse myWebResponse = req.GetResponse();
            using (StreamReader sr = new StreamReader(myWebResponse.GetResponseStream(), myEncoding))
            {
                string a = sr.ReadToEnd();
                return a;
            }
        }

    }
}
