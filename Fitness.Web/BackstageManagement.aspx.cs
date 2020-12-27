using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fitness.BLL;
using Fitness.DBUtility;
using Fitness.Model;

namespace Fitness.Web
{
    public partial class BackstageManagement : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Get_V_Insert_Reservation_User_Activity_And_Bind_Table();
                GetCityAndBindSelect();
                GetNameAndBindSelect();
            }
        }

        /// <summary>
        /// 获取视图并且绑定到后台管理表格中
        /// </summary>
        public void Get_V_Insert_Reservation_User_Activity_And_Bind_Table(string sql = "")
        {
            V_Insert_Reservation_User_Activity_BLL vInsertReservationUserActivityBll =
                new V_Insert_Reservation_User_Activity_BLL();
            List<V_Insert_Reservation_User_Activity_Model> vInsertReservationUserActivityModels =
                vInsertReservationUserActivityBll.GetModelList(sql);
            Repeater1.DataSource = vInsertReservationUserActivityModels;
            Repeater1.DataBind();
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
            DropDownList1.Items.Insert(0, new ListItem("请选则城市", "0"));
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
            DropDownList2.Items.Insert(0, new ListItem("请选择俱乐部", "0"));
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            // 城市名称
            string cityName = DropDownList1.SelectedValue;
            // 俱乐部名称
            string clubID = DropDownList2.SelectedValue;
            string sql = "";
            if (!string.IsNullOrEmpty(cityName))
            {
                cityName = "Fitness_Club_City='" + cityName + "'";
                sql = cityName;
            }

            if (!string.IsNullOrEmpty(clubID) && clubID != "0")
            {
                clubID = "Fitness_Club_ID='" + clubID + "'";
                sql = clubID;
            }

            if (!string.IsNullOrEmpty(cityName) && !string.IsNullOrEmpty(clubID) && clubID != "0")
            {
                sql = cityName + " and " + clubID;
            }

            Get_V_Insert_Reservation_User_Activity_And_Bind_Table(sql);
        }

        protected void DropDownList1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string dropDownList1Value = DropDownList1.SelectedValue;
            GetNameAndBindSelect(dropDownList1Value);
        }
    }
}