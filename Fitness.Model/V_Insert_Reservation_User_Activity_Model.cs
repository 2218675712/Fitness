using System;

namespace Fitness.Model
{
    /// <summary>
    /// V_Insert_Reservation_User_Activity_Model:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class V_Insert_Reservation_User_Activity_Model
    {
        public V_Insert_Reservation_User_Activity_Model()
        {
        }

        #region Model

        private Guid _reservation_user_id;
        private string _reservation_user_name;
        private string _reservation_user_phone;
        private int _reservation_user_sex;
        private DateTime _reservation_user_create_time;
        private Guid _reservation_activity_id;
        private string _reservation_activity_name;
        private DateTime? _reservation_activity_start_time;
        private DateTime? _reservation_activity_end_time;
        private int? _reservation_activity_number;
        private Guid _fitness_club_id;
        private string _fitness_club_city;
        private string _fitness_club_name;
        private int? _fitness_club_user;
        private string _fitness_club_address;
        private string _fitness_club_phone;
        private string _fitness_club_contact;

        /// <summary>
        /// 
        /// </summary>
        public Guid Reservation_User_ID
        {
            set { _reservation_user_id = value; }
            get { return _reservation_user_id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Reservation_User_Name
        {
            set { _reservation_user_name = value; }
            get { return _reservation_user_name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Reservation_User_Phone
        {
            set { _reservation_user_phone = value; }
            get { return _reservation_user_phone; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Reservation_User_Sex
        {
            set { _reservation_user_sex = value; }
            get { return _reservation_user_sex; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime Reservation_User_Create_Time
        {
            set { _reservation_user_create_time = value; }
            get { return _reservation_user_create_time; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Guid Reservation_Activity_ID
        {
            set { _reservation_activity_id = value; }
            get { return _reservation_activity_id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Reservation_Activity_Name
        {
            set { _reservation_activity_name = value; }
            get { return _reservation_activity_name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? Reservation_Activity_Start_Time
        {
            set { _reservation_activity_start_time = value; }
            get { return _reservation_activity_start_time; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? Reservation_Activity_End_Time
        {
            set { _reservation_activity_end_time = value; }
            get { return _reservation_activity_end_time; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? Reservation_Activity_Number
        {
            set { _reservation_activity_number = value; }
            get { return _reservation_activity_number; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Guid Fitness_Club_ID
        {
            set { _fitness_club_id = value; }
            get { return _fitness_club_id; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fitness_Club_City
        {
            set { _fitness_club_city = value; }
            get { return _fitness_club_city; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fitness_Club_Name
        {
            set { _fitness_club_name = value; }
            get { return _fitness_club_name; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int? Fitness_Club_User
        {
            set { _fitness_club_user = value; }
            get { return _fitness_club_user; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fitness_Club_Address
        {
            set { _fitness_club_address = value; }
            get { return _fitness_club_address; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fitness_Club_Phone
        {
            set { _fitness_club_phone = value; }
            get { return _fitness_club_phone; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Fitness_Club_Contact
        {
            set { _fitness_club_contact = value; }
            get { return _fitness_club_contact; }
        }

        #endregion Model
    }
}