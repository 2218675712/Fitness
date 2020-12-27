using System;
using System.Data;
using System.Collections.Generic;
using Fitness.DAL;
using Fitness.Model;

namespace Fitness.BLL
{
    /// <summary>
    /// V_Insert_Reservation_User_Activity_BLL
    /// </summary>
    public partial class V_Insert_Reservation_User_Activity_BLL
    {
        private readonly V_Insert_Reservation_User_Activity_DAL dal = new V_Insert_Reservation_User_Activity_DAL();

        public V_Insert_Reservation_User_Activity_BLL()
        {
        }

        #region BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid Reservation_User_ID, string Reservation_User_Name, string Reservation_User_Phone,
            int Reservation_User_Sex, DateTime Reservation_User_Create_Time, Guid Reservation_Activity_ID,
            string Reservation_Activity_Name, DateTime Reservation_Activity_Start_Time,
            DateTime Reservation_Activity_End_Time, int Reservation_Activity_Number, Guid Fitness_Club_ID,
            string Fitness_Club_City, string Fitness_Club_Name, int Fitness_Club_User, string Fitness_Club_Address,
            string Fitness_Club_Phone, string Fitness_Club_Contact)
        {
            return dal.Exists(Reservation_User_ID, Reservation_User_Name, Reservation_User_Phone, Reservation_User_Sex,
                Reservation_User_Create_Time, Reservation_Activity_ID, Reservation_Activity_Name,
                Reservation_Activity_Start_Time, Reservation_Activity_End_Time, Reservation_Activity_Number,
                Fitness_Club_ID, Fitness_Club_City, Fitness_Club_Name, Fitness_Club_User, Fitness_Club_Address,
                Fitness_Club_Phone, Fitness_Club_Contact);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(V_Insert_Reservation_User_Activity_Model model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(V_Insert_Reservation_User_Activity_Model model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid Reservation_User_ID, string Reservation_User_Name, string Reservation_User_Phone,
            int Reservation_User_Sex, DateTime Reservation_User_Create_Time, Guid Reservation_Activity_ID,
            string Reservation_Activity_Name, DateTime Reservation_Activity_Start_Time,
            DateTime Reservation_Activity_End_Time, int Reservation_Activity_Number, Guid Fitness_Club_ID,
            string Fitness_Club_City, string Fitness_Club_Name, int Fitness_Club_User, string Fitness_Club_Address,
            string Fitness_Club_Phone, string Fitness_Club_Contact)
        {
            return dal.Delete(Reservation_User_ID, Reservation_User_Name, Reservation_User_Phone, Reservation_User_Sex,
                Reservation_User_Create_Time, Reservation_Activity_ID, Reservation_Activity_Name,
                Reservation_Activity_Start_Time, Reservation_Activity_End_Time, Reservation_Activity_Number,
                Fitness_Club_ID, Fitness_Club_City, Fitness_Club_Name, Fitness_Club_User, Fitness_Club_Address,
                Fitness_Club_Phone, Fitness_Club_Contact);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public V_Insert_Reservation_User_Activity_Model GetModel(Guid Reservation_User_ID, string Reservation_User_Name,
            string Reservation_User_Phone, int Reservation_User_Sex, DateTime Reservation_User_Create_Time,
            Guid Reservation_Activity_ID, string Reservation_Activity_Name, DateTime Reservation_Activity_Start_Time,
            DateTime Reservation_Activity_End_Time, int Reservation_Activity_Number, Guid Fitness_Club_ID,
            string Fitness_Club_City, string Fitness_Club_Name, int Fitness_Club_User, string Fitness_Club_Address,
            string Fitness_Club_Phone, string Fitness_Club_Contact)
        {
            return dal.GetModel(Reservation_User_ID, Reservation_User_Name, Reservation_User_Phone,
                Reservation_User_Sex, Reservation_User_Create_Time, Reservation_Activity_ID, Reservation_Activity_Name,
                Reservation_Activity_Start_Time, Reservation_Activity_End_Time, Reservation_Activity_Number,
                Fitness_Club_ID, Fitness_Club_City, Fitness_Club_Name, Fitness_Club_User, Fitness_Club_Address,
                Fitness_Club_Phone, Fitness_Club_Contact);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<V_Insert_Reservation_User_Activity_Model> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<V_Insert_Reservation_User_Activity_Model> DataTableToList(DataTable dt)
        {
            List<V_Insert_Reservation_User_Activity_Model> modelList =
                new List<V_Insert_Reservation_User_Activity_Model>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                V_Insert_Reservation_User_Activity_Model model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }

            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion BasicMethod

        #region ExtensionMethod

        #endregion ExtensionMethod
    }
}