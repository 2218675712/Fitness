﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Fitness.DBUtility;
using Fitness.Model;

namespace Fitness.DAL
{
    /// <summary>
    /// 数据访问类:Reservation_User_DAL
    /// </summary>
    public partial class Reservation_User_DAL
    {
        public Reservation_User_DAL()
        {
        }

        #region BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Reservation_User");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Reservation_User_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Reservation_User(");
            strSql.Append("ID,City,Fitness_Club_ID,Name,Sex,Phone,Create_Time,Activity_ID)");
            strSql.Append(" values (");
            strSql.Append("@ID,@City,@Fitness_Club_ID,@Name,@Sex,@Phone,@Create_Time,@Activity_ID)");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Fitness_Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Sex", SqlDbType.Int, 4),
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Create_Time", SqlDbType.DateTime),
                new SqlParameter("@Activity_ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.City;
            // parameters[2].Value = Guid.NewGuid();
            parameters[2].Value = model.Fitness_Club_ID;
            parameters[3].Value = model.Name;
            parameters[4].Value = model.Sex;
            parameters[5].Value = model.Phone;
            parameters[6].Value = model.Create_Time;
            // parameters[7].Value = Guid.NewGuid();
            parameters[7].Value = model.Activity_ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Reservation_User_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Reservation_User set ");
            strSql.Append("City=@City,");
            strSql.Append("Fitness_Club_ID=@Fitness_Club_ID,");
            strSql.Append("Name=@Name,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Create_Time=@Create_Time,");
            strSql.Append("Activity_ID=@Activity_ID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Fitness_Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Sex", SqlDbType.Int, 4),
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Create_Time", SqlDbType.DateTime),
                new SqlParameter("@Activity_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = model.City;
            parameters[1].Value = model.Fitness_Club_ID;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.Create_Time;
            parameters[6].Value = model.Activity_ID;
            parameters[7].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(Guid ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Reservation_User ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Reservation_User ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Reservation_User_Model GetModel(Guid ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select  top 1 ID,City,Fitness_Club_ID,Name,Sex,Phone,Create_Time,Activity_ID from Reservation_User ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = ID;

            Reservation_User_Model model = new Reservation_User_Model();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Reservation_User_Model DataRowToModel(DataRow row)
        {
            Reservation_User_Model model = new Reservation_User_Model();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = new Guid(row["ID"].ToString());
                }

                if (row["City"] != null)
                {
                    model.City = row["City"].ToString();
                }

                if (row["Fitness_Club_ID"] != null && row["Fitness_Club_ID"].ToString() != "")
                {
                    model.Fitness_Club_ID = new Guid(row["Fitness_Club_ID"].ToString());
                }

                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }

                if (row["Sex"] != null && row["Sex"].ToString() != "")
                {
                    model.Sex = int.Parse(row["Sex"].ToString());
                }

                if (row["Phone"] != null)
                {
                    model.Phone = row["Phone"].ToString();
                }

                if (row["Create_Time"] != null && row["Create_Time"].ToString() != "")
                {
                    model.Create_Time = DateTime.Parse(row["Create_Time"].ToString());
                }

                if (row["Activity_ID"] != null && row["Activity_ID"].ToString() != "")
                {
                    model.Activity_ID = new Guid(row["Activity_ID"].ToString());
                }
            }

            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,City,Fitness_Club_ID,Name,Sex,Phone,Create_Time,Activity_ID ");
            strSql.Append(" FROM Reservation_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }

            strSql.Append(" ID,City,Fitness_Club_ID,Name,Sex,Phone,Create_Time,Activity_ID ");
            strSql.Append(" FROM Reservation_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM Reservation_User ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }

            strSql.Append(")AS Row, T.*  from Reservation_User T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }

            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "Reservation_User";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion BasicMethod

        #region ExtensionMethod

        #endregion ExtensionMethod
    }
}