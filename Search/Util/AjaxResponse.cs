using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// Ajax响应处理程序
    /// </summary>
    public class AjaxResponse:IDisposable
    {
        /// <summary>
        /// 返回成功与否
        /// </summary>
        public bool success { get; set; }

        /// <summary>
        /// 返回的信息
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// 返回的错误信息
        /// </summary>
        public string error { get; set; }

        #region###赋值
        public static string Response(bool success,string msg,string error)
        {
            using (AjaxResponse a = new AjaxResponse())
            {
                a.success = success;
                a.msg = msg;
                a.error = error;
                return "[" + JsonHelper.Jso_ToJSON(a) + "]";
            }
        }
        #endregion
       /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-6-23
        ******************************/
        #region###释放资源
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-6-23
        ******************************/
        #region###析构函数
        /// <summary>
        /// 析构函数
        /// </summary>
        ~AjaxResponse()
        {
            this.Dispose();
        }
        #endregion
    }
}
