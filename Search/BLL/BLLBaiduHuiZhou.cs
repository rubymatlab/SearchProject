using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/******************************
** 作者： 周永丰
** 变更时间： 2011-9-19
** 引用程序集
** DAL
******************************/

/******************************
** 作者： 周永丰
** 变更时间： 2011-9-19
** 命名空间
******************************/
using DAL;
using ORM;
namespace BLL
{
    public class BLLBaiduHuiZhou : IDisposable
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        public string error = null;

/******************************
** 作者： 周永丰
** 变更时间： 2011-8-26
******************************/
        /// <summary>
        /// 将百度惠州的单条数据插入
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        #region###百度惠州数据插入
        public bool Insert_Position_BaiduHuiZhou(baiduhuizhou a)
        {
            try
            {
                DALPosition.Insert_Position_BaiduHuiZhou(a);
                DALPosition.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;

            }
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-8-26
        ******************************/
        #region###百度惠州数据查询
        public bool Select_Position_BaiduHuiZhou(string pos_positionurl)
        {
            return DALPosition.Select_Position_BaiduHuiZhou(pos_positionurl);
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-8-26
        ******************************/
        #region###释放资源
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-8-26
        ******************************/
        #region###析构函数
        /// <summary>
        /// 析构函数
        /// </summary>
        ~BLLBaiduHuiZhou()
        {
            this.Dispose();
        }
        #endregion
    }
}
