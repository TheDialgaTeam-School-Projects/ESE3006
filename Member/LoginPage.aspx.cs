using Modules.System.Data.SqlClient;
using Modules.System.Web.UI.WebControls;
using System;
using System.Data.SqlClient;
using System.Web.UI;
using Modules.System.Security.Cryptography;

public partial class Member_LoginPage : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Login");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Member/RegisterPage.aspx");
    }

    protected void btnForgetPassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Member/ForgetPassword.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            txtError.Text = "Username or Password is empty.";
        else
        {
            using (SqlClientHelper sql = new SqlClientHelper())
            {
                using (SqlDataReader Reader = sql.Query("select * from Account where Username = @Username", txtUsername.Text.Trim()))
                {
                    if (Reader.Read())
                    {
                        if (Reader["Password"].ToString().DecryptString(txtUsername.Text.Trim()) == txtPassword.Text)
                        {
                            if (Reader["IsBanned"].ToString() == "0")
                            {
                                Session["Account.Username"] = Reader["Username"].ToString();
                                Session["Account.IsAdmin"] = Reader["IsAdmin"].ToString();
                                Session["Account.IsLoggedIn"] = "1";
                                Response.Redirect("~/Member/LoginComplete.aspx");
                            }
                            else
                                txtError.Text = "Status: Your account have been banned.";
                        }
                        else
                            txtError.Text = "Status: Incorrect username or password. Please try again.";
                    }
                    else
                        txtError.Text = "Status: Incorrect username or password. Please try again.";
                }
            }
        }
    }
}