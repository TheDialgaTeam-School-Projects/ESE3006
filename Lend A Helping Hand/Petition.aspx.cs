using Modules.System.Data.SqlClient;
using Modules.System.Web.UI.WebControls;
using System;
using System.Data.SqlClient;
using System.Web.UI;

public partial class Lend_A_Helping_Hand_Petition : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MenuHelper.InitNavigationBar(Master, "Lend A Helping Hand/Petition");

        if (!Page.IsPostBack)
        {
            if (Session["Account.IsLoggedIn"] != null && Session["Account.IsLoggedIn"].ToString() == "1")
            {
                using (SqlClientHelper sql = new SqlClientHelper())
                {
                    using (SqlDataReader Reader = sql.Query("select * from Account where Username = @Username", Session["Account.Username"].ToString()))
                    {
                        Reader.Read();
                        lblAccountName.Text = Reader["Username"].ToString();
                    }
                }
            }
            else
                Response.Redirect("~/Member/Error.aspx");
        }

        using (SqlClientHelper sql = new SqlClientHelper())
        {
            using (SqlDataReader Reader = sql.Query("select * from Petition"))
            {
                GridView1.DataSource = Reader;
                GridView1.DataBind();
            }
        }
    }

    protected void btnSignPetition_Click(object sender, EventArgs e)
    {
        DateTime currentTime = DateTime.Now;
        int accountID;

        using (SqlClientHelper sql = new SqlClientHelper())
        {
            using (SqlDataReader Reader = sql.Query("select * from Account where Username = @Username", Session["Account.Username"].ToString()))
            {
                Reader.Read();
                accountID = Convert.ToInt32(Reader["ID"]);
            }

            sql.Query("insert into Petition (AccountID, DateTime) values (@AccountID, @DateTime)", accountID, currentTime);

            using (SqlDataReader Reader = sql.Query("select * from Petition"))
            {
                GridView1.DataSource = Reader;
                GridView1.DataBind();
            }
        }
    }
}