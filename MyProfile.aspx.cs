using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//provide all the classes of the sql
using System.Configuration;


public partial class Default6 : System.Web.UI.Page
{
    static SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        
    }

   
    protected void Update(object sender, EventArgs e)
    {
        try
        {
           
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            conn.Open();

            string checkpass = "select password from [User] where UserName='" + UserName.Text + "'";
            SqlCommand passcom = new SqlCommand(checkpass, conn);
            String password = passcom.ExecuteScalar().ToString().Replace(" ", "");
            if (password == TextBox2.Text)
            {
                   string insertquery = " UPDATE [User] SET UserName=@us ,Email=@em ,Country=@co,City=@ci,PhoneNumber=@ph,Password=@pa  where Username='" + Session["New"].ToString() + "' ";
            SqlCommand com = new SqlCommand(insertquery, conn);
            com.Parameters.AddWithValue("@us", UserName.Text);
            com.Parameters.AddWithValue("@em", Email.Text);
            com.Parameters.AddWithValue("@co", Country.Text);
            com.Parameters.AddWithValue("@ci", City.Text);
            com.Parameters.AddWithValue("@ph", PhoneNumber.Text);
            com.Parameters.AddWithValue("@pa", Password.Text);
            com.ExecuteNonQuery();
            Response.Write("Your data is updated successfuly");
            }
            else
            {
                Response.Write("Pleaze inter correct Old pass");
            }
            
            conn.Close();
           
            
        }
        catch (Exception ex)
        {
            Response.Write("error:" + ex.ToString());
        }
    }

    
  
    protected void View(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
        conn.Open();
        string Searchquery = " select * from [User] where Username='" + Session["New"].ToString() + "'";
        SqlCommand com2 = new SqlCommand(Searchquery, conn);
        dr = com2.ExecuteReader();
        dr.Read();
        UserName.Text = dr[0].ToString().Replace(" ", "");
        Email.Text = dr[1].ToString().Replace(" ", "");
        Country.Text = dr[2].ToString().Replace(" ", "");
        City.Text = dr[3].ToString().Replace(" ", "");
        PhoneNumber.Text = dr[4].ToString().Replace(" ", "");
        Password.Text = dr[5].ToString().Replace(" ", "");
        conn.Close();
    }
}