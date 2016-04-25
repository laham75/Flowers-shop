using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using WebSite1;
using System.Data.SqlClient;
using System.Configuration;

public partial class LoginE : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LogIn(object sender, EventArgs e)
    {


        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
        conn.Open();
        string checkuser = "select count(*) from employee where Username='" + UserName.Text + "'";
        SqlCommand com = new SqlCommand(checkuser, conn);
        Int32 count = Convert.ToInt32(com.ExecuteScalar().ToString());


        if (count == 1)
        {

            string checkpass = "select password from employee where Username='" + UserName.Text + "'";
            SqlCommand passcom = new SqlCommand(checkpass, conn);
            String password = passcom.ExecuteScalar().ToString().Replace(" ", "");


            if (password == Password.Text)
            {
                Session["New"] = UserName.Text;
                Session["New1"] = "UserE";
                Response.Write("Password is correct");
                Response.Redirect("management.aspx");
                
             
            }

            else
            {
                Response.Write("Password is not correct");
            }

        }
        else
        {
            Response.Write("UserName is not correct");
        }
        conn.Close();
    }
}