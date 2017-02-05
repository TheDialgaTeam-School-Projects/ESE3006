using Modules.System.Web.UI.WebControls;
using System;
using System.Web.UI;

public partial class Home : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Home");
    }
}