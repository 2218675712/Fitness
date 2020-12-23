using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fitness.BLL;
using Fitness.DBUtility;
using Fitness.Model;

namespace Fitness.Web
{
    public partial class information : Page
    {
        private string Fitness_Club_ID = "";
        private string Activity_ID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 获取地址列表
                GetCityAndBindSelect();
                GetNameAndBindSelect();
            }
        }


        protected void DropDownList1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string dropDownList1Value = DropDownList1.SelectedValue;

            GetNameAndBindSelect(dropDownList1Value);
        }

        /// <summary>
        /// 从数据库获取城市并设置下拉框
        /// </summary>
        private void GetCityAndBindSelect()
        {
            DropDownList1.DataSource = DbHelperSQL.Query("select distinct City from Fitness_Club");
            // 绑定下拉框文字
            DropDownList1.DataTextField = "City";
            //绑定下拉框value值
            DropDownList1.DataValueField = "City";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("城市名称", "0"));
        }

        /// <summary>
        /// 从数据库获取俱乐部名称并设置下拉框
        /// </summary>
        private void GetNameAndBindSelect(string dropDownList1Value = "")
        {
            Fitness_Club_BLL fitnessClubBll = new Fitness_Club_BLL();
            List<Fitness_Club_Model> fitnessClubModels;
            // 判断是查全部还是根据指定城市查询部分
            if (string.IsNullOrEmpty(dropDownList1Value))
            {
                fitnessClubModels = fitnessClubBll.GetModelList("");
            }
            else
            {
                fitnessClubModels = fitnessClubBll.GetModelList("city='" + dropDownList1Value + "'");
            }

            // 给下拉框绑定
            DropDownList2.DataSource = fitnessClubModels;
            // 绑定下拉框文字
            DropDownList2.DataTextField = "Name";
            //绑定下拉框value值
            DropDownList2.DataValueField = "ID";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("俱乐部名称", "0"));
 

        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            // 城市名称
            string cityName = DropDownList1.SelectedValue;
            // 俱乐部名称
            string clubName = DropDownList2.SelectedValue;
            string name = TextBox1.Text;
            string phone = TextBox2.Text;
            string sex = DropDownList3.SelectedValue;

            // 获取活动信息
            bool result1=GetActivity();
            if (!result1)
            {
                return;
            }


            Reservation_User_Model reservationUserModel = new Reservation_User_Model();
            reservationUserModel.ID = new Guid();
            reservationUserModel.City = cityName;
            reservationUserModel.Fitness_Club_ID = new Guid(Fitness_Club_ID);
            reservationUserModel.Name = name;
            reservationUserModel.Sex = Convert.ToInt32(sex);
            reservationUserModel.Create_Time = DateTime.Now;
            reservationUserModel.Activity_ID = new Guid(Activity_ID);
            reservationUserModel.Phone = phone;
            Reservation_User_BLL reservationUserBll = new Reservation_User_BLL();
            bool result2 = reservationUserBll.Add(reservationUserModel);
            if (!result2)
            {
                Response.Write("预约失败,请联系管理员");
                return;
            }
            Response.Write("预约成功,跳转到成功页面");
        }

        /// <summary>
        /// 获取活动信息
        /// </summary>
        public bool GetActivity()
        {
            // 设置俱乐部的id
            Fitness_Club_ID = DropDownList2.SelectedValue;

            Reservation_Activity_BLL reservationActivityBll = new Reservation_Activity_BLL();
            List<Reservation_Activity_Model> reservationActivityModels =
                reservationActivityBll.GetModelList("Club_ID='" + Fitness_Club_ID + "'");
            if (reservationActivityModels == null)
            {
                Response.Write("查询没有该活动,请重试");
                return false;
            }

            var model = reservationActivityModels.FirstOrDefault();
            DateTime nowDateTime = DateTime.Now;
            if (model == null || model.Start_Time > nowDateTime || model.End_Time < nowDateTime)
            {
                Response.Write("活动未开始或已经结束,请重试");
                return false;
            }

            // 活动人数加1
            model.Reservation_Number = model.Reservation_Number + 1;
            reservationActivityBll.Update(model);
            
            // 设置活动id
            Activity_ID = model.ID.ToString();
            return true;
        }
    }
}