using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LogOut(object sender, EventArgs e)
    {
       
        Session["New"] = null;
        Session["New1"] = null;
        Response.Redirect("Default.aspx");
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