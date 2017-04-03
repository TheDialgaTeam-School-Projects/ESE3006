using Modules.System;
using Modules.System.Data.SqlClient;
using Modules.System.Web.UI.WebControls;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI;

public partial class Member_Profile : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Your Profile/Update Particulars");

        if (!Page.IsPostBack)
        {
            if (Session["Account.IsLoggedIn"] != null && Session["Account.IsLoggedIn"].ToString() == "1")
            {
                using (SqlClientHelper sql = new SqlClientHelper())
                {
                    using (SqlDataReader Reader = sql.Query("select * from Account where Username = @Username", Session["Account.Username"].ToString()))
                    {
                        Reader.Read();
                        txtName.Text = Reader["Username"].ToString();
                        txtEmail.Text = Reader["Email"].ToString();
                        Avatar.ImageUrl = "~/Images/Avatar/" + Reader["Avatar"].ToString();
                    }
                }
            }
            else
                Response.Redirect("~/Member/Error.aspx");
        }
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            if (FileUpload1.PostedFile.ContentType.Equals("image/bmp", "image/x-windows-bmp", "image/gif", "image/jpeg", "image/pjpeg", "image/png"))
            {
                try
                {
                    string fileName = "Avatar_" + txtName.Text + Path.GetExtension(FileUpload1.FileName);
                    FileUpload1.SaveAs(Server.MapPath("~/Images/Avatar/" + fileName));
                    using (SqlClientHelper sql = new SqlClientHelper())
                        sql.Query("update Account set Avatar = @Avatar where Username = @Username", fileName, txtName.Text);
                }
                catch (Exception ex)
                {
                    txtUploadStatus.Text = ex.Message;
                }
            }
            else
                txtUploadStatus.Text = "Invalid Image file.";
        }
        else
            txtUploadStatus.Text = "No image is uploaded.";
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        using (SqlClientHelper sql = new SqlClientHelper())
        {
            if (txtPassword.Text == "")
                sql.Query("update Account set Email = @Email where Username = @Username", txtEmail.Text.Trim(), Session["Account.Username"].ToString());
            else
                sql.Query("update Account set Email = @Email, Password = @Password where Username = @Username", txtEmail.Text.Trim(), txtPassword.Text, Session["Account.Username"].ToString());
        }
    }
}