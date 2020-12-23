using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Fitness.DBUtility;
using Fitness.Model;

namespace Fitness.DAL
{
    /// <summary>
    /// 数据访问类:Reservation_Activity_DAl
    /// </summary>
    public partial class Reservation_Activity_DAl
    {
        public Reservation_Activity_DAl()
        {
        }

        #region BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Reservation_Activity");
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
        public bool Add(Reservation_Activity_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Reservation_Activity(");
            strSql.Append("ID,Name,Start_Time,End_Time,Reservation_Number,Club_ID)");
            strSql.Append(" values (");
            strSql.Append("@ID,@Name,@Start_Time,@End_Time,@Reservation_Number,@Club_ID)");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Name", SqlDbType.NVarChar, 30),
                new SqlParameter("@Start_Time", SqlDbType.DateTime),
                new SqlParameter("@End_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Number", SqlDbType.Int, 4),
                new SqlParameter("@Club_ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Start_Time;
            parameters[3].Value = model.End_Time;
            parameters[4].Value = model.Reservation_Number;
            // parameters[5].Value = Guid.NewGuid();
            parameters[5].Value = model.Club_ID;

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
        public bool Update(Reservation_Activity_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Reservation_Activity set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Start_Time=@Start_Time,");
            strSql.Append("End_Time=@End_Time,");
            strSql.Append("Reservation_Number=@Reservation_Number,");
            strSql.Append("Club_ID=@Club_ID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", SqlDbType.NVarChar, 30),
                new SqlParameter("@Start_Time", SqlDbType.DateTime),
                new SqlParameter("@End_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Number", SqlDbType.Int, 4),
                new SqlParameter("@Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Start_Time;
            parameters[2].Value = model.End_Time;
            parameters[3].Value = model.Reservation_Number;
            parameters[4].Value = model.Club_ID;
            parameters[5].Value = model.ID;

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
            strSql.Append("delete from Reservation_Activity ");
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
            strSql.Append("delete from Reservation_Activity ");
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
        public Reservation_Activity_Model GetModel(Guid ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select  top 1 ID,Name,Start_Time,End_Time,Reservation_Number,Club_ID from Reservation_Activity ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16)
            };
            parameters[0].Value = ID;

            Reservation_Activity_Model model = new Reservation_Activity_Model();
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
        public Reservation_Activity_Model DataRowToModel(DataRow row)
        {
            Reservation_Activity_Model model = new Reservation_Activity_Model();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = new Guid(row["ID"].ToString());
                }

                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }

                if (row["Start_Time"] != null && row["Start_Time"].ToString() != "")
                {
                    model.Start_Time = DateTime.Parse(row["Start_Time"].ToString());
                }

                if (row["End_Time"] != null && row["End_Time"].ToString() != "")
                {
                    model.End_Time = DateTime.Parse(row["End_Time"].ToString());
                }

                if (row["Reservation_Number"] != null && row["Reservation_Number"].ToString() != "")
                {
                    model.Reservation_Number = int.Parse(row["Reservation_Number"].ToString());
                }

                if (row["Club_ID"] != null && row["Club_ID"].ToString() != "")
                {
                    model.Club_ID = new Guid(row["Club_ID"].ToString());
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
            strSql.Append("select ID,Name,Start_Time,End_Time,Reservation_Number,Club_ID ");
            strSql.Append(" FROM Reservation_Activity ");
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

            strSql.Append(" ID,Name,Start_Time,End_Time,Reservation_Number,Club_ID ");
            strSql.Append(" FROM Reservation_Activity ");
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
            strSql.Append("select count(1) FROM Reservation_Activity ");
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

            strSql.Append(")AS Row, T.*  from Reservation_Activity T ");
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
            parameters[0].Value = "Reservation_Activity";
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