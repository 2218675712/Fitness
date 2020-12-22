using System;

namespace Fitness.Model
{
    /// <summary>
    /// 预约表
    /// </summary>
    [Serializable]
    public partial class Reservation_User_Model
    {
        public Reservation_User_Model()
        {
        }

        #region Model

        private Guid _id;
        private string _city;
        private Guid _fitness_club_id;
        private string _name;
        private int _sex;
        private string _phone;
        private DateTime _create_time = DateTime.Now;
        private Guid _activity_id;

        /// <summary>
        /// 预约用户ID
        /// </summary>
        public Guid ID
        {
            set { _id = value; }
            get { return _id; }
        }

        /// <summary>
        /// 城市
        /// </summary>
        public string City
        {
            set { _city = value; }
            get { return _city; }
        }

        /// <summary>
        /// 俱乐部主键ID
        /// </summary>
        public Guid Fitness_Club_ID
        {
            set { _fitness_club_id = value; }
            get { return _fitness_club_id; }
        }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public int Sex
        {
            set { _sex = value; }
            get { return _sex; }
        }

        /// <summary>
        /// 预约用户手机号
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }

        /// <summary>
        /// 预约时间
        /// </summary>
        public DateTime Create_Time
        {
            set { _create_time = value; }
            get { return _create_time; }
        }

        /// <summary>
        /// 活动ID
        /// </summary>
        public Guid Activity_ID
        {
            set { _activity_id = value; }
            get { return _activity_id; }
        }

        #endregion Model
    }
}