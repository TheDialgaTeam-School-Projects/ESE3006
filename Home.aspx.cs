using AjaxControlToolkit;
using Modules.System.Web.UI.WebControls;
using System;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;

public partial class Home : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Home");
    }

    [WebMethod, ScriptMethod]
    public static Slide[] GetImages()
    {
        Slide[] test = new Slide[2];
        test[0] = new Slide("Images/HomePage1.jpg", "1", "");
        test[1] = new Slide("Images/HomePage2.jpg", "2", "");
        return test;
    }
}