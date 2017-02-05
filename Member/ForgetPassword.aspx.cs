using Modules.System.Data.SqlClient;
using Modules.System.Security.Cryptography;
using Modules.System.Web.UI.WebControls;
using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Member_ForgetPassword : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Login");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Member/LoginPage.aspx");
    }

    protected void btnGetPassword_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text))
            txt_Status.Text = "Username or Email is empty.";
        else
        {
            using (SqlClientHelper sql = new SqlClientHelper())
            {
                using (SqlDataReader Reader = sql.Query("select Password from Account where Username = @Username And Email = @Email", txtUsername.Text.Trim(), txtEmail.Text.Trim()))
                {
                    if (Reader.Read())
                        txt_Status.Text = "Status: Your Password for " + txtUsername.Text + " is " + Reader["Password"].ToString().DecryptString(txtUsername.Text.Trim());
                    else
                        txt_Status.Text = "Status: Username and/or Email does not exist.";
                }
            }
        }
    }
}