using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    void Page_PreInit(Object sender, EventArgs e)
    {


        if (Session["New"] == null)
        {
            Page.MasterPageFile = "Site.master";
        }

        else
        {
            if (Session["New"].ToString().Replace(" ", "") == "admin")
            {
                Page.MasterPageFile = "MasterE.master";
            }

            else
            {
                Page.MasterPageFile = "MasterPage.master";
            }

        }

    }
}