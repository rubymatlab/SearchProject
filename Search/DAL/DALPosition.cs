using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/******************************
** 作者： 周永丰
** 变更时间： 2011-8-26
** 引用程序集
** ORM、Util、System.Data.Linq
******************************/

/******************************
** 作者： 周永丰
** 变更时间： 2011-8-26
** 命名空间
******************************/
using System.Data.Linq;
using ORM;
namespace DAL
{
    public class DALPosition
    {
        /// <summary>
        /// 数据库
        /// </summary>
        private static SearchDataContext db = new SearchDataContext();

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-8-26
        ******************************/
        /// <summary>
        /// 增加数据
        /// </summary>
        /// <param name="a"></param>
        #region###增加富海人才网的数据
        public static void Insert_Position_FuHai(fuhaiposition a)
        {
            db.fuhaiposition.InsertOnSubmit(a);
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-8-26
        ******************************/
        #region###判断富海人才网数据是否在本地数据库存在
        public static bool Select_Position_FuHai(string pos_positionurl)
        {
            if (db.fuhaiposition.Where(o => o.pos_positionurl == pos_positionurl).Count() > 0)
                return true;
            else
                return false;
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-9-1
        ******************************/
        /// <summary>
        /// 增加聚能人才网数据
        /// </summary>
        /// <param name="a">聚能人才网对象</param>
        #region###增加聚能人才网的数据
        public static void Insert_Position_JuNeng(junengposition a)
        {
            db.junengposition.InsertOnSubmit(a);
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-9-1
        ******************************/
        #region###判断聚能人才网数据是否在本地数据库存在
        public static bool Select_Position_JuNeng(string pos_positionurl)
        {
            if (db.junengposition.Where(o => o.pos_positionurl == pos_positionurl).Count() > 0)
                return true;
            else
                return false;
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-9-19
        ******************************/
        #region###判断百度惠州数据是否在本地数据库存在
        public static bool Select_Position_BaiduHuiZhou(string pos_positionurl)
        {
            if (db.baiduhuizhou.Where(o => o.pos_positionurl == pos_positionurl).Count() > 0)
                return true;
            else
                return false;
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-9-19
        ******************************/
        /// <summary>
        /// 增加百度惠州数据
        /// </summary>
        /// <param name="a">百度惠州对象</param>
        #region###增加百度惠州的数据
        public static void Insert_Position_BaiduHuiZhou(baiduhuizhou a)
        {
            db.baiduhuizhou.InsertOnSubmit(a);
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-9-19
        ******************************/
        /// <summary>
        /// 添加网站数据
        /// </summary>
        /// <param name="a">所有网站的插入</param>
        #region###增加百度惠州的数据
        public static void Insert_Position(position a)
        {
            db.position.InsertOnSubmit(a);
        }
        #endregion

        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-9-19
        ******************************/
        #region###判断所在网站数据是否在本地数据库存在
        public static bool Select_Position(string pos_positionurl)
        {
            if (db.position.Where(o => o.pos_positionurl == pos_positionurl).Count() > 0)
                return true;
            else
                return false;
        }
        #endregion


        /******************************
        ** 作者： 周永丰
        ** 变更时间： 2011-8-20
        ******************************/
        #region###提交更改数据
        public static void SubmitChanges()
        {
            try
            {
                db.SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict);
            }
            catch (System.Data.Linq.ChangeConflictException ex)
            {
                foreach (System.Data.Linq.ObjectChangeConflict occ in db.ChangeConflicts)
                {
                    // 只更新实体对象中改变的字段的值，其他的保留不变
                    occ.Resolve(System.Data.Linq.RefreshMode.KeepChanges);
                }
                // 这个地方要注意，Catch方法中，我们前面只是指明了怎样来解决冲突，这个地方还需要再次提交更新，这样的话，值    //才会提交到数据库。
                db.SubmitChanges();
            }
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
        ~DALPosition()
        {
            this.Dispose();
        }
        #endregion
    }
}
