using System;

namespace Fitness.Model
{
    /// <summary>
    /// 预约活动
    /// </summary>
    [Serializable]
    public partial class Reservation_Activity_Model
    {
        public Reservation_Activity_Model()
        {
        }

        #region Model

        private Guid _id;
        private string _name;
        private DateTime _start_time = DateTime.Now;
        private DateTime _end_time = Convert.ToDateTime(DateTime.Now.AddMonths(1));
        private int _reservation_number = 0;
        private Guid _club_id;

        /// <summary>
        /// 活动ID
        /// </summary>
        public Guid ID
        {
            set { _id = value; }
            get { return _id; }
        }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime Start_Time
        {
            set { _start_time = value; }
            get { return _start_time; }
        }

        /// <summary>
        /// 活动结束时间
        // 默认一个月
        /// </summary>
        public DateTime End_Time
        {
            set { _end_time = value; }
            get { return _end_time; }
        }

        /// <summary>
        /// 预约人数
        /// </summary>
        public int Reservation_Number
        {
            set { _reservation_number = value; }
            get { return _reservation_number; }
        }

        /// <summary>
        /// 俱乐部ID
        /// </summary>
        public Guid Club_ID
        {
            set { _club_id = value; }
            get { return _club_id; }
        }

        #endregion Model
    }
}