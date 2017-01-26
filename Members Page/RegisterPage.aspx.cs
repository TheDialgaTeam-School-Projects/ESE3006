﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Members_Page_RegisterPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Members Page/LoginPage.aspx");
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        bool error = false;

        if (string.IsNullOrEmpty(txtUsername.Text))
        {
            lbl_username_status.Text = "Username is empty!";
            error = true;
        }
        else if (txtUsername.Text.Length > 50)
        {
            lbl_username_status.Text = "Username is too long. Please shorten it.";
            error = true;
        }

        if (string.IsNullOrEmpty(txtPassword.Text))
        {
            lbl_password_status.Text = "Password is empty!";
            error = true;
        }
        else if (txtPassword.Text.Length > 50)
        {
            lbl_password_status.Text = "Password is too long. Please shorten it.";
            error = true;
        }

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

        if (string.IsNullOrEmpty(txtEmail.Text))
        {
            lbl_email_status.Text = "Email is empty!";
            error = true;
        }

        if (!error)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = localhost; Initial Catalog = ASP; user = user; password = Password_2013"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("select count(*) from Account where Username = '" + txtUsername.Text + "'", conn))
                {
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                        lbl_username_status.Text = "Username exists. Please try again!";
                    else
                    {
                        using (SqlCommand cmd2 = new SqlCommand("insert into Account (Username, Password, Email) values (@Username, @Password, @Email)", conn))
                        {
                            cmd2.Prepare();
                            cmd2.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd2.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd2.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd2.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}