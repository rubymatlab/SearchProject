﻿using System;
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
            fuhaiposition b = new fuhaiposition();
            b.pos_address = a.pos_address;
            b.pos_business = a.pos_business;
            b.pos_company = a.pos_company;
            b.pos_companyurl = a.pos_companyurl;
            b.pos_count = a.pos_count;
            b.pos_degree = a.pos_degree;
            b.pos_from = a.pos_from;
            b.pos_fromurl = a.pos_fromurl;
            b.pos_position = a.pos_position;
            b.pos_positionurl = a.pos_positionurl;
            b.pos_salary = a.pos_salary;
            b.pos_time = a.pos_time;
            b.pos_workexperience = a.pos_workexperience;
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
            junengposition b = new junengposition();
            b.pos_address = a.pos_address;
            b.pos_business = a.pos_business;
            b.pos_company = a.pos_company;
            b.pos_companyurl = a.pos_companyurl;
            b.pos_count = a.pos_count;
            b.pos_degree = a.pos_degree;
            b.pos_from = a.pos_from;
            b.pos_fromurl = a.pos_fromurl;
            b.pos_position = a.pos_position;
            b.pos_positionurl = a.pos_positionurl;
            b.pos_salary = a.pos_salary;
            b.pos_time = a.pos_time;
            b.pos_workexperience = a.pos_workexperience;
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
