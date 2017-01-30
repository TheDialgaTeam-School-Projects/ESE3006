using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Members Page/RegisterPage.aspx");
    }

    protected void btnForgetPassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Members Page/ForgetPassword.aspx");
    }
}