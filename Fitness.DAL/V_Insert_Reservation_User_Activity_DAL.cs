using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Fitness.DBUtility;
using Fitness.Model;

namespace Fitness.DAL
{
    /// <summary>
    /// 数据访问类:V_Insert_Reservation_User_Activity_DAL
    /// </summary>
    public partial class V_Insert_Reservation_User_Activity_DAL
    {
        public V_Insert_Reservation_User_Activity_DAL()
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from V_Insert_Reservation_User_Activity");
            strSql.Append(
                " where Reservation_User_ID=@Reservation_User_ID and Reservation_User_Name=@Reservation_User_Name and Reservation_User_Phone=@Reservation_User_Phone and Reservation_User_Sex=@Reservation_User_Sex and Reservation_User_Create_Time=@Reservation_User_Create_Time and Reservation_Activity_ID=@Reservation_Activity_ID and Reservation_Activity_Name=@Reservation_Activity_Name and Reservation_Activity_Start_Time=@Reservation_Activity_Start_Time and Reservation_Activity_End_Time=@Reservation_Activity_End_Time and Reservation_Activity_Number=@Reservation_Activity_Number and Fitness_Club_ID=@Fitness_Club_ID and Fitness_Club_City=@Fitness_Club_City and Fitness_Club_Name=@Fitness_Club_Name and Fitness_Club_User=@Fitness_Club_User and Fitness_Club_Address=@Fitness_Club_Address and Fitness_Club_Phone=@Fitness_Club_Phone and Fitness_Club_Contact=@Fitness_Club_Contact ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Reservation_User_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_User_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Sex", SqlDbType.Int, 4),
                new SqlParameter("@Reservation_User_Create_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_Activity_Name", SqlDbType.NVarChar, 30),
                new SqlParameter("@Reservation_Activity_Start_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_End_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_Number", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Fitness_Club_City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Fitness_Club_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_User", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_Address", SqlDbType.NVarChar, 50),
                new SqlParameter("@Fitness_Club_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_Contact", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = Reservation_User_ID;
            parameters[1].Value = Reservation_User_Name;
            parameters[2].Value = Reservation_User_Phone;
            parameters[3].Value = Reservation_User_Sex;
            parameters[4].Value = Reservation_User_Create_Time;
            parameters[5].Value = Reservation_Activity_ID;
            parameters[6].Value = Reservation_Activity_Name;
            parameters[7].Value = Reservation_Activity_Start_Time;
            parameters[8].Value = Reservation_Activity_End_Time;
            parameters[9].Value = Reservation_Activity_Number;
            parameters[10].Value = Fitness_Club_ID;
            parameters[11].Value = Fitness_Club_City;
            parameters[12].Value = Fitness_Club_Name;
            parameters[13].Value = Fitness_Club_User;
            parameters[14].Value = Fitness_Club_Address;
            parameters[15].Value = Fitness_Club_Phone;
            parameters[16].Value = Fitness_Club_Contact;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(V_Insert_Reservation_User_Activity_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into V_Insert_Reservation_User_Activity(");
            strSql.Append(
                "Reservation_User_ID,Reservation_User_Name,Reservation_User_Phone,Reservation_User_Sex,Reservation_User_Create_Time,Reservation_Activity_ID,Reservation_Activity_Name,Reservation_Activity_Start_Time,Reservation_Activity_End_Time,Reservation_Activity_Number,Fitness_Club_ID,Fitness_Club_City,Fitness_Club_Name,Fitness_Club_User,Fitness_Club_Address,Fitness_Club_Phone,Fitness_Club_Contact)");
            strSql.Append(" values (");
            strSql.Append(
                "@Reservation_User_ID,@Reservation_User_Name,@Reservation_User_Phone,@Reservation_User_Sex,@Reservation_User_Create_Time,@Reservation_Activity_ID,@Reservation_Activity_Name,@Reservation_Activity_Start_Time,@Reservation_Activity_End_Time,@Reservation_Activity_Number,@Fitness_Club_ID,@Fitness_Club_City,@Fitness_Club_Name,@Fitness_Club_User,@Fitness_Club_Address,@Fitness_Club_Phone,@Fitness_Club_Contact)");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Reservation_User_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_User_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Sex", SqlDbType.Int, 4),
                new SqlParameter("@Reservation_User_Create_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_Activity_Name", SqlDbType.NVarChar, 30),
                new SqlParameter("@Reservation_Activity_Start_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_End_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_Number", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Fitness_Club_City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Fitness_Club_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_User", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_Address", SqlDbType.NVarChar, 50),
                new SqlParameter("@Fitness_Club_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_Contact", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = Guid.NewGuid();
            parameters[1].Value = model.Reservation_User_Name;
            parameters[2].Value = model.Reservation_User_Phone;
            parameters[3].Value = model.Reservation_User_Sex;
            parameters[4].Value = model.Reservation_User_Create_Time;
            parameters[5].Value = Guid.NewGuid();
            parameters[6].Value = model.Reservation_Activity_Name;
            parameters[7].Value = model.Reservation_Activity_Start_Time;
            parameters[8].Value = model.Reservation_Activity_End_Time;
            parameters[9].Value = model.Reservation_Activity_Number;
            parameters[10].Value = Guid.NewGuid();
            parameters[11].Value = model.Fitness_Club_City;
            parameters[12].Value = model.Fitness_Club_Name;
            parameters[13].Value = model.Fitness_Club_User;
            parameters[14].Value = model.Fitness_Club_Address;
            parameters[15].Value = model.Fitness_Club_Phone;
            parameters[16].Value = model.Fitness_Club_Contact;

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
        public bool Update(V_Insert_Reservation_User_Activity_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update V_Insert_Reservation_User_Activity set ");
            strSql.Append("Reservation_User_ID=@Reservation_User_ID,");
            strSql.Append("Reservation_User_Name=@Reservation_User_Name,");
            strSql.Append("Reservation_User_Phone=@Reservation_User_Phone,");
            strSql.Append("Reservation_User_Sex=@Reservation_User_Sex,");
            strSql.Append("Reservation_User_Create_Time=@Reservation_User_Create_Time,");
            strSql.Append("Reservation_Activity_ID=@Reservation_Activity_ID,");
            strSql.Append("Reservation_Activity_Name=@Reservation_Activity_Name,");
            strSql.Append("Reservation_Activity_Start_Time=@Reservation_Activity_Start_Time,");
            strSql.Append("Reservation_Activity_End_Time=@Reservation_Activity_End_Time,");
            strSql.Append("Reservation_Activity_Number=@Reservation_Activity_Number,");
            strSql.Append("Fitness_Club_ID=@Fitness_Club_ID,");
            strSql.Append("Fitness_Club_City=@Fitness_Club_City,");
            strSql.Append("Fitness_Club_Name=@Fitness_Club_Name,");
            strSql.Append("Fitness_Club_User=@Fitness_Club_User,");
            strSql.Append("Fitness_Club_Address=@Fitness_Club_Address,");
            strSql.Append("Fitness_Club_Phone=@Fitness_Club_Phone,");
            strSql.Append("Fitness_Club_Contact=@Fitness_Club_Contact");
            strSql.Append(
                " where Reservation_User_ID=@Reservation_User_ID and Reservation_User_Name=@Reservation_User_Name and Reservation_User_Phone=@Reservation_User_Phone and Reservation_User_Sex=@Reservation_User_Sex and Reservation_User_Create_Time=@Reservation_User_Create_Time and Reservation_Activity_ID=@Reservation_Activity_ID and Reservation_Activity_Name=@Reservation_Activity_Name and Reservation_Activity_Start_Time=@Reservation_Activity_Start_Time and Reservation_Activity_End_Time=@Reservation_Activity_End_Time and Reservation_Activity_Number=@Reservation_Activity_Number and Fitness_Club_ID=@Fitness_Club_ID and Fitness_Club_City=@Fitness_Club_City and Fitness_Club_Name=@Fitness_Club_Name and Fitness_Club_User=@Fitness_Club_User and Fitness_Club_Address=@Fitness_Club_Address and Fitness_Club_Phone=@Fitness_Club_Phone and Fitness_Club_Contact=@Fitness_Club_Contact ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Reservation_User_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_User_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Sex", SqlDbType.Int, 4),
                new SqlParameter("@Reservation_User_Create_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_Activity_Name", SqlDbType.NVarChar, 30),
                new SqlParameter("@Reservation_Activity_Start_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_End_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_Number", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Fitness_Club_City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Fitness_Club_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_User", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_Address", SqlDbType.NVarChar, 50),
                new SqlParameter("@Fitness_Club_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_Contact", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = model.Reservation_User_ID;
            parameters[1].Value = model.Reservation_User_Name;
            parameters[2].Value = model.Reservation_User_Phone;
            parameters[3].Value = model.Reservation_User_Sex;
            parameters[4].Value = model.Reservation_User_Create_Time;
            parameters[5].Value = model.Reservation_Activity_ID;
            parameters[6].Value = model.Reservation_Activity_Name;
            parameters[7].Value = model.Reservation_Activity_Start_Time;
            parameters[8].Value = model.Reservation_Activity_End_Time;
            parameters[9].Value = model.Reservation_Activity_Number;
            parameters[10].Value = model.Fitness_Club_ID;
            parameters[11].Value = model.Fitness_Club_City;
            parameters[12].Value = model.Fitness_Club_Name;
            parameters[13].Value = model.Fitness_Club_User;
            parameters[14].Value = model.Fitness_Club_Address;
            parameters[15].Value = model.Fitness_Club_Phone;
            parameters[16].Value = model.Fitness_Club_Contact;

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
        public bool Delete(Guid Reservation_User_ID, string Reservation_User_Name, string Reservation_User_Phone,
            int Reservation_User_Sex, DateTime Reservation_User_Create_Time, Guid Reservation_Activity_ID,
            string Reservation_Activity_Name, DateTime Reservation_Activity_Start_Time,
            DateTime Reservation_Activity_End_Time, int Reservation_Activity_Number, Guid Fitness_Club_ID,
            string Fitness_Club_City, string Fitness_Club_Name, int Fitness_Club_User, string Fitness_Club_Address,
            string Fitness_Club_Phone, string Fitness_Club_Contact)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from V_Insert_Reservation_User_Activity ");
            strSql.Append(
                " where Reservation_User_ID=@Reservation_User_ID and Reservation_User_Name=@Reservation_User_Name and Reservation_User_Phone=@Reservation_User_Phone and Reservation_User_Sex=@Reservation_User_Sex and Reservation_User_Create_Time=@Reservation_User_Create_Time and Reservation_Activity_ID=@Reservation_Activity_ID and Reservation_Activity_Name=@Reservation_Activity_Name and Reservation_Activity_Start_Time=@Reservation_Activity_Start_Time and Reservation_Activity_End_Time=@Reservation_Activity_End_Time and Reservation_Activity_Number=@Reservation_Activity_Number and Fitness_Club_ID=@Fitness_Club_ID and Fitness_Club_City=@Fitness_Club_City and Fitness_Club_Name=@Fitness_Club_Name and Fitness_Club_User=@Fitness_Club_User and Fitness_Club_Address=@Fitness_Club_Address and Fitness_Club_Phone=@Fitness_Club_Phone and Fitness_Club_Contact=@Fitness_Club_Contact ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Reservation_User_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_User_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Sex", SqlDbType.Int, 4),
                new SqlParameter("@Reservation_User_Create_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_Activity_Name", SqlDbType.NVarChar, 30),
                new SqlParameter("@Reservation_Activity_Start_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_End_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_Number", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Fitness_Club_City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Fitness_Club_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_User", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_Address", SqlDbType.NVarChar, 50),
                new SqlParameter("@Fitness_Club_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_Contact", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = Reservation_User_ID;
            parameters[1].Value = Reservation_User_Name;
            parameters[2].Value = Reservation_User_Phone;
            parameters[3].Value = Reservation_User_Sex;
            parameters[4].Value = Reservation_User_Create_Time;
            parameters[5].Value = Reservation_Activity_ID;
            parameters[6].Value = Reservation_Activity_Name;
            parameters[7].Value = Reservation_Activity_Start_Time;
            parameters[8].Value = Reservation_Activity_End_Time;
            parameters[9].Value = Reservation_Activity_Number;
            parameters[10].Value = Fitness_Club_ID;
            parameters[11].Value = Fitness_Club_City;
            parameters[12].Value = Fitness_Club_Name;
            parameters[13].Value = Fitness_Club_User;
            parameters[14].Value = Fitness_Club_Address;
            parameters[15].Value = Fitness_Club_Phone;
            parameters[16].Value = Fitness_Club_Contact;

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
        public V_Insert_Reservation_User_Activity_Model GetModel(Guid Reservation_User_ID, string Reservation_User_Name,
            string Reservation_User_Phone, int Reservation_User_Sex, DateTime Reservation_User_Create_Time,
            Guid Reservation_Activity_ID, string Reservation_Activity_Name, DateTime Reservation_Activity_Start_Time,
            DateTime Reservation_Activity_End_Time, int Reservation_Activity_Number, Guid Fitness_Club_ID,
            string Fitness_Club_City, string Fitness_Club_Name, int Fitness_Club_User, string Fitness_Club_Address,
            string Fitness_Club_Phone, string Fitness_Club_Contact)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(
                "select  top 1 Reservation_User_ID,Reservation_User_Name,Reservation_User_Phone,Reservation_User_Sex,Reservation_User_Create_Time,Reservation_Activity_ID,Reservation_Activity_Name,Reservation_Activity_Start_Time,Reservation_Activity_End_Time,Reservation_Activity_Number,Fitness_Club_ID,Fitness_Club_City,Fitness_Club_Name,Fitness_Club_User,Fitness_Club_Address,Fitness_Club_Phone,Fitness_Club_Contact from V_Insert_Reservation_User_Activity ");
            strSql.Append(
                " where Reservation_User_ID=@Reservation_User_ID and Reservation_User_Name=@Reservation_User_Name and Reservation_User_Phone=@Reservation_User_Phone and Reservation_User_Sex=@Reservation_User_Sex and Reservation_User_Create_Time=@Reservation_User_Create_Time and Reservation_Activity_ID=@Reservation_Activity_ID and Reservation_Activity_Name=@Reservation_Activity_Name and Reservation_Activity_Start_Time=@Reservation_Activity_Start_Time and Reservation_Activity_End_Time=@Reservation_Activity_End_Time and Reservation_Activity_Number=@Reservation_Activity_Number and Fitness_Club_ID=@Fitness_Club_ID and Fitness_Club_City=@Fitness_Club_City and Fitness_Club_Name=@Fitness_Club_Name and Fitness_Club_User=@Fitness_Club_User and Fitness_Club_Address=@Fitness_Club_Address and Fitness_Club_Phone=@Fitness_Club_Phone and Fitness_Club_Contact=@Fitness_Club_Contact ");
            SqlParameter[] parameters =
            {
                new SqlParameter("@Reservation_User_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_User_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Reservation_User_Sex", SqlDbType.Int, 4),
                new SqlParameter("@Reservation_User_Create_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Reservation_Activity_Name", SqlDbType.NVarChar, 30),
                new SqlParameter("@Reservation_Activity_Start_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_End_Time", SqlDbType.DateTime),
                new SqlParameter("@Reservation_Activity_Number", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_ID", SqlDbType.UniqueIdentifier, 16),
                new SqlParameter("@Fitness_Club_City", SqlDbType.NVarChar, 10),
                new SqlParameter("@Fitness_Club_Name", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_User", SqlDbType.Int, 4),
                new SqlParameter("@Fitness_Club_Address", SqlDbType.NVarChar, 50),
                new SqlParameter("@Fitness_Club_Phone", SqlDbType.NVarChar, 20),
                new SqlParameter("@Fitness_Club_Contact", SqlDbType.NVarChar, 10)
            };
            parameters[0].Value = Reservation_User_ID;
            parameters[1].Value = Reservation_User_Name;
            parameters[2].Value = Reservation_User_Phone;
            parameters[3].Value = Reservation_User_Sex;
            parameters[4].Value = Reservation_User_Create_Time;
            parameters[5].Value = Reservation_Activity_ID;
            parameters[6].Value = Reservation_Activity_Name;
            parameters[7].Value = Reservation_Activity_Start_Time;
            parameters[8].Value = Reservation_Activity_End_Time;
            parameters[9].Value = Reservation_Activity_Number;
            parameters[10].Value = Fitness_Club_ID;
            parameters[11].Value = Fitness_Club_City;
            parameters[12].Value = Fitness_Club_Name;
            parameters[13].Value = Fitness_Club_User;
            parameters[14].Value = Fitness_Club_Address;
            parameters[15].Value = Fitness_Club_Phone;
            parameters[16].Value = Fitness_Club_Contact;

            V_Insert_Reservation_User_Activity_Model model = new V_Insert_Reservation_User_Activity_Model();
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
        public V_Insert_Reservation_User_Activity_Model DataRowToModel(DataRow row)
        {
            V_Insert_Reservation_User_Activity_Model model = new V_Insert_Reservation_User_Activity_Model();
            if (row != null)
            {
                if (row["Reservation_User_ID"] != null && row["Reservation_User_ID"].ToString() != "")
                {
                    model.Reservation_User_ID = new Guid(row["Reservation_User_ID"].ToString());
                }

                if (row["Reservation_User_Name"] != null)
                {
                    model.Reservation_User_Name = row["Reservation_User_Name"].ToString();
                }

                if (row["Reservation_User_Phone"] != null)
                {
                    model.Reservation_User_Phone = row["Reservation_User_Phone"].ToString();
                }

                if (row["Reservation_User_Sex"] != null && row["Reservation_User_Sex"].ToString() != "")
                {
                    model.Reservation_User_Sex = int.Parse(row["Reservation_User_Sex"].ToString());
                }

                if (row["Reservation_User_Create_Time"] != null && row["Reservation_User_Create_Time"].ToString() != "")
                {
                    model.Reservation_User_Create_Time = DateTime.Parse(row["Reservation_User_Create_Time"].ToString());
                }

                if (row["Reservation_Activity_ID"] != null && row["Reservation_Activity_ID"].ToString() != "")
                {
                    model.Reservation_Activity_ID = new Guid(row["Reservation_Activity_ID"].ToString());
                }

                if (row["Reservation_Activity_Name"] != null)
                {
                    model.Reservation_Activity_Name = row["Reservation_Activity_Name"].ToString();
                }

                if (row["Reservation_Activity_Start_Time"] != null &&
                    row["Reservation_Activity_Start_Time"].ToString() != "")
                {
                    model.Reservation_Activity_Start_Time =
                        DateTime.Parse(row["Reservation_Activity_Start_Time"].ToString());
                }

                if (row["Reservation_Activity_End_Time"] != null &&
                    row["Reservation_Activity_End_Time"].ToString() != "")
                {
                    model.Reservation_Activity_End_Time =
                        DateTime.Parse(row["Reservation_Activity_End_Time"].ToString());
                }

                if (row["Reservation_Activity_Number"] != null && row["Reservation_Activity_Number"].ToString() != "")
                {
                    model.Reservation_Activity_Number = int.Parse(row["Reservation_Activity_Number"].ToString());
                }

                if (row["Fitness_Club_ID"] != null && row["Fitness_Club_ID"].ToString() != "")
                {
                    model.Fitness_Club_ID = new Guid(row["Fitness_Club_ID"].ToString());
                }

                if (row["Fitness_Club_City"] != null)
                {
                    model.Fitness_Club_City = row["Fitness_Club_City"].ToString();
                }

                if (row["Fitness_Club_Name"] != null)
                {
                    model.Fitness_Club_Name = row["Fitness_Club_Name"].ToString();
                }

                if (row["Fitness_Club_User"] != null && row["Fitness_Club_User"].ToString() != "")
                {
                    model.Fitness_Club_User = int.Parse(row["Fitness_Club_User"].ToString());
                }

                if (row["Fitness_Club_Address"] != null)
                {
                    model.Fitness_Club_Address = row["Fitness_Club_Address"].ToString();
                }

                if (row["Fitness_Club_Phone"] != null)
                {
                    model.Fitness_Club_Phone = row["Fitness_Club_Phone"].ToString();
                }

                if (row["Fitness_Club_Contact"] != null)
                {
                    model.Fitness_Club_Contact = row["Fitness_Club_Contact"].ToString();
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
            strSql.Append(
                "select Reservation_User_ID,Reservation_User_Name,Reservation_User_Phone,Reservation_User_Sex,Reservation_User_Create_Time,Reservation_Activity_ID,Reservation_Activity_Name,Reservation_Activity_Start_Time,Reservation_Activity_End_Time,Reservation_Activity_Number,Fitness_Club_ID,Fitness_Club_City,Fitness_Club_Name,Fitness_Club_User,Fitness_Club_Address,Fitness_Club_Phone,Fitness_Club_Contact ");
            strSql.Append(" FROM V_Insert_Reservation_User_Activity ");
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

            strSql.Append(
                " Reservation_User_ID,Reservation_User_Name,Reservation_User_Phone,Reservation_User_Sex,Reservation_User_Create_Time,Reservation_Activity_ID,Reservation_Activity_Name,Reservation_Activity_Start_Time,Reservation_Activity_End_Time,Reservation_Activity_Number,Fitness_Club_ID,Fitness_Club_City,Fitness_Club_Name,Fitness_Club_User,Fitness_Club_Address,Fitness_Club_Phone,Fitness_Club_Contact ");
            strSql.Append(" FROM V_Insert_Reservation_User_Activity ");
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
            strSql.Append("select count(1) FROM V_Insert_Reservation_User_Activity ");
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
                strSql.Append("order by T.Fitness_Club_Contact desc");
            }

            strSql.Append(")AS Row, T.*  from V_Insert_Reservation_User_Activity T ");
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
            parameters[0].Value = "V_Insert_Reservation_User_Activity";
            parameters[1].Value = "Fitness_Club_Contact";
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