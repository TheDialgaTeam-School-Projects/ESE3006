using Modules.System.Web.UI.WebControls;
using System;
using System.Web.UI;

public partial class Member_Logout : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Login");

        Session["Account.IsAdmin"] = "0";
        Session["Account.IsLoggedIn"] = "0";

        if (!Page.IsPostBack)
            Session["PAGE_TIMER"] = 0;
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        int pageTime = (int)Session["PAGE_TIMER"];
        Session["PAGE_TIMER"] = ++pageTime;

        if (pageTime >= 5)
            Response.Redirect("~/Home.aspx");
        else
            txtRemainingTime.Text = (5 - pageTime).ToString();
    }
}