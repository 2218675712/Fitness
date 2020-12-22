using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Fitness.DBUtility;
using Fitness.Model;

namespace Fitness.DAL
{
    /// <summary>
    /// 数据访问类:Fitness_Club_DAL
    /// </summary>
    public partial class Fitness_Club_DAL
    {
        public Fitness_Club_DAL()
        {
        }

        #region BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(Guid ID, string City)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Fitness_Club");
            strSql.Append(" where ID=@ID and City=@City ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@City", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = ID;
            parameters[1].Value = City;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Fitness_Club_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Fitness_Club(");
            strSql.Append("ID,City,Name,Max_User,Address,Phone,Contact)");
            strSql.Append(" values (");
            strSql.Append("@ID,@City,@Name,@Max_User,@Address,@Phone,@Contact)");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Max_User", SqlDbType.Int, 4),
                new SqlParameter("@Address", SqlDbType.NVarChar, 50),
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Contact", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.City;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.Max_User;
            parameters[4].Value = model.Address;
            parameters[5].Value = model.Phone;
            parameters[6].Value = model.Contact;

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
        public bool Update(Fitness_Club_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Fitness_Club set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Max_User=@Max_User,");
            strSql.Append("Address=@Address,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Contact=@Contact");
            strSql.Append(" where ID=@ID and City=@City ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Max_User", SqlDbType.Int, 4),
                new SqlParameter("@Address", SqlDbType.NVarChar, 50),
                new SqlParameter("@Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Contact", SqlDbType.NVarChar, 10),
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@City", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Max_User;
            parameters[2].Value = model.Address;
            parameters[3].Value = model.Phone;
            parameters[4].Value = model.Contact;
            parameters[5].Value = model.ID;
            parameters[6].Value = model.City;

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
        public bool Delete(Guid ID, string City)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Fitness_Club ");
            strSql.Append(" where ID=@ID and City=@City ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@City", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = ID;
            parameters[1].Value = City;

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
        /// 得到一个对象实体
        /// </summary>
        public Fitness_Club_Model GetModel(Guid ID, string City)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,City,Name,Max_User,Address,Phone,Contact from Fitness_Club ");
            strSql.Append(" where ID=@ID and City=@City ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@City", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = ID;
            parameters[1].Value = City;

            Fitness_Club_Model model = new Fitness_Club_Model();
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
        public Fitness_Club_Model DataRowToModel(DataRow row)
        {
            Fitness_Club_Model model = new Fitness_Club_Model();
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

                if (row["Name"] != null)
                {
                    model.Name = row["Name"].ToString();
                }

                if (row["Max_User"] != null && row["Max_User"].ToString() != "")
                {
                    model.Max_User = int.Parse(row["Max_User"].ToString());
                }

                if (row["Address"] != null)
                {
                    model.Address = row["Address"].ToString();
                }

                if (row["Phone"] != null)
                {
                    model.Phone = row["Phone"].ToString();
                }

                if (row["Contact"] != null)
                {
                    model.Contact = row["Contact"].ToString();
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
            strSql.Append("select ID,City,Name,Max_User,Address,Phone,Contact ");
            strSql.Append(" FROM Fitness_Club ");
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

            strSql.Append(" ID,City,Name,Max_User,Address,Phone,Contact ");
            strSql.Append(" FROM Fitness_Club ");
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
            strSql.Append("select count(1) FROM Fitness_Club ");
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
                strSql.Append("order by T.City desc");
            }

            strSql.Append(")AS Row, T.*  from Fitness_Club T ");
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
            parameters[0].Value = "Fitness_Club";
            parameters[1].Value = "City";
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