using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//provide all the classes of the sql
using System.Configuration;

public partial class Reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from [User] where Username='" + UserName.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, conn);
            Int32 count = Convert.ToInt32(com.ExecuteScalar().ToString());


            if (count == 1)
            {
                Response.Write("user already exists");
            }
            
            conn.Close();
        }
    }
    protected void Register(object sender, EventArgs e)
    {
        
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();
            string insertquery = " insert into [User] (UserName,Email,Country,City,PhoneNumber,Password) values (@un,@em,@co,@ci,@ph,@pa) ";
            SqlCommand com = new SqlCommand(insertquery, conn);
            com.Parameters.AddWithValue("@un", UserName.Text);
            com.Parameters.AddWithValue("@em", Email.Text);
            com.Parameters.AddWithValue("@co", Country.Text);
            com.Parameters.AddWithValue("@ci", City.Text);
            com.Parameters.AddWithValue("@ph", PhoneNumber.Text);
            com.Parameters.AddWithValue("@pa", Password.Text);
            com.ExecuteNonQuery();           
            Response.Redirect("Login.aspx");

            conn.Close();
        }
}
    




