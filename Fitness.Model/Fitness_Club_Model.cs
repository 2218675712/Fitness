using System;

namespace Fitness.Model
{
    /// <summary>
    /// 健身俱乐部表
    /// </summary>
    [Serializable]
    public partial class Fitness_Club_Model
    {
        public Fitness_Club_Model()
        {
        }

        #region Model

        private Guid _id;
        private string _city;
        private string _name;
        private int _max_user;
        private string _address;
        private string _phone;
        private string _contact;

        /// <summary>
        /// 俱乐部ID
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
        /// 俱乐部名称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        /// <summary>
        /// 最大人数
        /// </summary>
        public int Max_User
        {
            set { _max_user = value; }
            get { return _max_user; }
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact
        {
            set { _contact = value; }
            get { return _contact; }
        }

        #endregion Model
    }
}