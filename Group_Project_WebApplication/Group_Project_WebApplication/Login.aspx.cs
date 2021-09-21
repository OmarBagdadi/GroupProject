using Group_Project_WebApplication.ServiceReference1;
using HashPass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = uEmail.Value;
            string password = Secrecy.HashPassword(uPassword.Value);
            var user = client.SignIn(username, password);
            if(user is User)
            {
                Session["UserID"] = user.Id;
                Session["UserType"] = user.Usertype;
                Session["UserName"] = user.Name;
                Session["UserSurname"] = user.Surname;
                Session["UserEmail"] = user.Email;
                Session["UserPhoneNo"] = user.PhoneNo;
                Response.Redirect("Home.aspx");
            }else
            {
                loginStatus.Visible = true;
                loginStatus.InnerText = "User does not exist";
            }
        }
    }
}