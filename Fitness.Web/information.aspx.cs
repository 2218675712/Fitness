using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fitness.BLL;
using Fitness.DBUtility;
using Fitness.Model;

namespace Fitness.Web
{
    public partial class information : Page
    {
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
            /*
            Fitness_Club_BLL fitnessClubBll = new Fitness_Club_BLL();

            // 给下拉框绑定
            DropDownList1.DataSource = fitnessClubBll.GetModelList("");
            */
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
            DropDownList2.DataValueField = "Name";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("俱乐部名称", "0"));
        }
    }
}