using Modules.System.Web.UI.WebControls;
using System;
using System.Web.UI;

public partial class Member_LoginComplete : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Login");

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