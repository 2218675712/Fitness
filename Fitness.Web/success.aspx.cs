using System;
using System.Web.UI;
using Fitness.BLL;
using Fitness.Model;


namespace Fitness.Web
{
    public partial class success : Page
    {
        private string Activity_ID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            Activity_ID = Request["Activity_ID"];
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Activity_ID))
                {
                    GetActivityInformation();
                }
            }
        }

        public void GetActivityInformation()
        {
            Reservation_Activity_BLL reservationActivityBll = new Reservation_Activity_BLL();
            Reservation_Activity_Model reservationActivityModel = new Reservation_Activity_Model();
            reservationActivityModel = reservationActivityBll.GetModel(new Guid(Activity_ID));
            Label1.Text = "开始时间:" + reservationActivityModel.Start_Time + "<br/>结束时间:" +
                          reservationActivityModel.End_Time;
            Label2.Text = reservationActivityModel.Name;
            Fitness_Club_BLL fitnessClubBll = new Fitness_Club_BLL();
            Fitness_Club_Model fitnessClubModel = new Fitness_Club_Model();
            fitnessClubModel = fitnessClubBll.GetModel(reservationActivityModel.Club_ID);
            Label3.Text = fitnessClubModel.Address;
            Label4.Text = fitnessClubModel.Phone + " " + fitnessClubModel.Contact[0] + " 先生/女士";
        }
    }
}