using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//provide all the classes of the sql
using System.Configuration;

public partial class ProfileE : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
    static SqlDataReader dr; 
    protected void Page_Load(object sender, EventArgs e)
    {
      
          
       
        
    }
    protected void Update(object sender, EventArgs e)
    {
       
            
            conn.Open();




            if (Session["New"].ToString().Replace(" ", "") != "admin")
            {
                string insertquery = " UPDATE [employee] SET UserName=@U ,Password=@P where Username='" + Session["New"].ToString().Replace(" ", "") + "' ";
                SqlCommand com = new SqlCommand(insertquery, conn);
                com.Parameters.AddWithValue("@U", UserName.Text);
                com.Parameters.AddWithValue("@P", Password.Text);
                com.ExecuteNonQuery();
                Session["New"] = UserName.Text;
                Response.Write("Your data is updated successfuly");
            }
            else 
            {

                string insertquery = " UPDATE [employee] SET Password=@P where Username='" + Session["New"].ToString().Replace(" ", "") + "' ";
                SqlCommand com = new SqlCommand(insertquery, conn);
                String name = UserName.Text;
                String maseg = "Your data is updated successfuly";
                if (name != "admin")
                {
                    name = "admin";
                    Response.Write("You Can Not change The Admin Name");
                    maseg = "";
                }
                else
                {
                    com.Parameters.AddWithValue("@P", Password.Text);
                    com.ExecuteNonQuery();
                    Session["New"] = UserName.Text;
                    Response.Write(maseg);
                }
            }
           // Response.Redirect("ProfileE");


            conn.Close();
       
    }

 
    protected void View(object sender, EventArgs e)
    {
        
            conn.Open();
            string Searchquery = " select * from employee where Username='" + Session["New"].ToString().Replace(" ", "") + "'";
            SqlCommand com2 = new SqlCommand(Searchquery, conn);
            dr = com2.ExecuteReader();
            dr.Read();
            UserName.Text = dr[0].ToString().Replace(" ", "");
            Password.Text = dr[1].ToString().Replace(" ", "");

            conn.Close();
        
        
    }
    void Page_PreInit(Object sender, EventArgs e)
    {

        String CurrentName = null;
        if (Session["New1"] != null)
        {
            CurrentName = Convert.ToString(Session["New1"].ToString().Replace(" ", ""));

            if (CurrentName == "User")
            {
                Page.MasterPageFile = "MasterPage.master";
            }

            else
            {
                if (Session["New"].ToString().Replace(" ", "") == "admin")
                    Page.MasterPageFile = "MasterE.master";
                else
                    Page.MasterPageFile = "employee.master";
            }
        }


    }

}