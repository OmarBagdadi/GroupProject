using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserType"] != null)
            {
                Session["UserType"] = null;
                Session["UserID"] = null;
                Session["UserEmail"] = null;
                Response.Redirect("Home.aspx");
            }else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}