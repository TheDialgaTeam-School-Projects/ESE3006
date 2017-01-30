using System;

public partial class Members_Page_RegisterComplete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            Session["PAGE_TIMER"] = 0;
    }

    protected void Timer_Tick(object sender, EventArgs e)
    {
        int pageTime = (int)Session["PAGE_TIMER"];
        Session["PAGE_TIMER"] = ++pageTime;

        if (pageTime >= 5)
            Response.Redirect("~/Members Page/LoginPage.aspx");
        else
            txtRemainingTime.Text = (5 - pageTime).ToString();
    }
}