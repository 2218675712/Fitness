using System;
using System.Web.UI;

namespace Fitness.Web
{
    public partial class index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("information.aspx");
        }
    }
}