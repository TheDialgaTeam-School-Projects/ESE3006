using Modules.System.Data.SqlClient;
using Modules.System.Security.Cryptography;
using Modules.System.Web.UI.WebControls;
using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Member_RegisterPage : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Login");
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Member/LoginPage.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        bool error = false;

        if (string.IsNullOrEmpty(txtUsername.Text))
        {
            lbl_username_status.Text = "Username is empty!";
            error = true;
        }
        else
        {
            using (SqlClientHelper sql = new SqlClientHelper())
            {
                using (SqlDataReader Reader = sql.Query("select * from Account where Username = @Username", txtUsername.Text.Trim()))
                {
                    if (Reader.HasRows)
                    {
                        lbl_username_status.Text = "A user with this username exist. Please try again.";
                        error = true;
                    }
                    else
                        lbl_username_status.Text = "";
                }
            }
        }

        if (string.IsNullOrEmpty(txtPassword.Text))
        {
            lbl_password_status.Text = "Password is empty!";
            error = true;
        }
        else
            lbl_password_status.Text = "";

        if (string.IsNullOrEmpty(txtConfirmPassword.Text))
        {
            lbl_confirm_password_status.Text = "Confirm Password is empty!";
            error = true;
        }
        else if (txtPassword.Text != txtConfirmPassword.Text)
        {
            lbl_confirm_password_status.Text = "Password does not match. Please try again!";
            error = true;
        }
        else
            lbl_confirm_password_status.Text = "";

        if (string.IsNullOrEmpty(txtEmail.Text))
        {
            lbl_email_status.Text = "Email is empty!";
            error = true;
        }
        else
            lbl_email_status.Text = "";

        if (!error)
        {
            using (SqlClientHelper sql = new SqlClientHelper())
            {
                sql.Query("insert into Account(Username, Password, Email) values (@Username, @Password, @Email)", txtUsername.Text.Trim(), txtPassword.Text.EncryptString(txtUsername.Text.Trim()), txtEmail.Text.Trim());
                Response.Redirect("~/Member/RegisterComplete.aspx");
            }
        }
    }
}