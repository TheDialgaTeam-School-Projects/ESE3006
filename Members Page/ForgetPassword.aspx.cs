using System;
using System.Data.SqlClient;

public partial class Members_Page_ForgetPassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Members Page/LoginPage.aspx");
    }

    protected void btnGetPassword_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtEmail.Text))
            txt_Status.Text = "Username or Email is empty.";
        else
        {
            using (SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = ASP; user = user; password = Password_2013"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("select Password from Account where Username = @Username And Email = @Email", conn))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            txt_Status.Text = "Status: Your Password for " + txtUsername.Text + " is " + reader["Password"].ToString().DecryptString(txtUsername.Text.Trim());
                        else
                            txt_Status.Text = "Status: Username and/or Email does not exist.";
                    }
                }
            }
        }
    }
}