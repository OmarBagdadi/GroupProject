using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class SalonMaster : System.Web.UI.MasterPage
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserType"] != null)
            {
                userProfile.Visible = true;
                userIcon.Visible = true;
                showLogin.Visible = false;
                showRegister.Visible = false;
                string uName = Session["UserName"].ToString();
                string uSurname = Session["UserSurname"].ToString();
                string uEmail = Session["UserEmail"].ToString();
                string profile = "";
                if (Session["UserType"].ToString() == "CU")
                {
                    profile = "<div class=\"action\">"
                        +"<div class=\"profile\">"
                        +"<h6 onclick=\"menuToggle();\">" + uName + "</h3>"
                        + "<div class=\"menu\">"
                        + "<h3>" + uName + " " + uSurname + "<br><span>" + uEmail + "</span></h3>"
                            + "<ul>"
                            + "<li><img src=\"assets/images/user-icon.png\"><a href=\"Register.aspx?viewEdit=VIEW\">My Profile</a></li>"
                            + "<li><img src=\"assets/images/edit-icon.png\"><a href=\"Register.aspx?viewEdit=EDIT\">Edit Profile</a></li>"
                            + "<li hidden><img src=\"assets/images/register-staff-icon.png\"><a href=\"Register.aspx\">Register Staff</a></li>"
                            + "<li hidden><img src=\"assets/images/report-icon.png\"><a href=\"Register.aspx\">Reports</a></li>"
                            + "<li><img src=\"assets/images/Shopping-Cart.jfif\"><a href=\"Cart.aspx\">My Cart</a></li>"
                            + "<li><img src=\"assets/images/log-out-icon.png\"><a href=\"Logout.aspx\">Log Out</a></li>"
                            + "</ul>"
                        + "</div>"
                        + "</div>"
                        + "</div>";

                }else if(Session["UserType"].ToString() == "MA")
                {
                    profile = "<div class=\"action\">"
                        + "<div class=\"profile\">"
                        +"<h6 onclick=\"menuToggle();\">" + uName + "</h6>"
                    + "<div class=\"menu\">"
                    + "<h3>" + uName + " " + uSurname + "<br><span>" + uEmail + "</span></h3>"
                        + "<ul>"
                        + "<li><img src=\"assets/images/user-icon.png\"><a href=\"Register.aspx?viewEdit=VIEW\">My Profile</a></li>"
                        + "<li><img src=\"assets/images/edit-icon.png\"><a href=\"Register.aspx?viewEdit=EDIT\">Edit Profile</a></li>"
                        + "<li><img src=\"assets/images/register-staff-icon.png\"><a href=\"Register.aspx?registerStaff=REG\">Register Staff</a></li>"
                        + "<li><img src=\"assets/images/report-icon.png\"><a href=\"Register.aspx\">Reports</a></li>"
                        + "<li><img src=\"assets/images/Shopping-Cart.jfif\"><a href=\"Cart.aspx\">My Cart</a></li>"
                        + "<li><img src=\"assets/images/log-out-icon.png\"><a href=\"Logout.aspx\">Log Out</a></li>"
                        + "</ul>"
                    + "</div>"
                    + "</div>"
                    + "</div>";
                }
                userProfile.InnerHtml = profile;
            }
        }
    }
}