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
    public partial class Register : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserType"] != null)
            {

            }else
            {
               
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string Name = uName.Value;
            string Surname = uSurname.Value;
            string Email = uEmail.Value;
            string phoneNo = uPhoneNo.Value;
            string password = uPassword.Value;
            string CPassword = uCPassword.Value;
            if (password == CPassword)
            {
                bool isReg = client.Register(Name, Surname, Email, Secrecy.HashPassword(password), phoneNo, "CU");
                if (isReg)
                {
                    registerStatus.Visible = true;
                    registerStatus.InnerText = "Registered Sucessfully";
                    registerStatus.Attributes.Add("style:","color: green");
                }
                else
                {
                    registerStatus.Visible = true;
                    registerStatus.InnerText = "Did not register Try Again";
                    registerStatus.Attributes.Add("style:", "color: red");
                }
            }
            else
            {
                registerStatus.Visible = true;
                registerStatus.InnerText = "Password did not match Confirm Password";
                registerStatus.Attributes.Add("style:", "color: red");
            }
        }
    }
}