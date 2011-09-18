using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/******************************
** 作者： 周永丰
** 变更时间： 2011-8-26
** 引用程序集
** DAL
******************************/

/******************************
** 作者： 周永丰
** 变更时间： 2011-8-26
** 命名空间
******************************/
using DAL;
using ORM;
namespace BLL
{
    public class BLLJuNeng:IDisposable
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        public string error = null;

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-9-1
        ******************************/
        /// <summary>
        /// 将富海人才网的单条数据插入
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        #region###富海人才网数据插入
        public bool Insert_Position_JuNeng(junengposition a)
        {
            try
            {
                DALPosition.Insert_Position_JuNeng(a);
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
        ** 变更时间： 2011-9-1
        ******************************/
        #region###富海人才网数据插入
        public bool Select_Position_JuNeng(string pos_positionurl)
        {
            return DALPosition.Select_Position_JuNeng(pos_positionurl);
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
        ~BLLJuNeng()
        {
            this.Dispose();
        }
        #endregion
    }
}
