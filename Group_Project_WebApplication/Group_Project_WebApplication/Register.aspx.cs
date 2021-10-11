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
        bool edit = false;
        bool regStaff = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] != null)
            {
                if(Request.QueryString["viewEdit"] != null)
                {
                    if(Request.QueryString["viewEdit"].ToString() == "EDIT")
                    {
                        edit = true;
                    }else if(Request.QueryString["viewEdit"].ToString() == "VIEW")
                    {
                        edit = false;
                    }
                }else if(Request.QueryString["registerStaff"] != null)
                {
                    if(Request.QueryString["registerStaff"].ToString() == "REG")
                    {
                        regStaff = true;
                    }
                }
                if(Session["UserType"].ToString() == "CU")
                {
                    if(edit)
                    {
                        pageHeading.InnerText = "Edit Profile";
                        hidePassword.Visible = false;
                        hideCPassword.Visible = false;
                        vhideSI.Visible = false;
                        btnRegister.Text = "Edit Profile";
                    }
                    else
                    {
                        pageHeading.InnerText = "My Profile";
                        uName.Visible = false;
                        uSurname.Visible = false;
                        uEmail.Visible = false;
                        uPhoneNo.Visible = false;
                        hidePassword.Visible = false;
                        hideCPassword.Visible = false;
                        vhideSI.Visible = false;
                        vuName.Visible = true;
                        vuName.InnerText = Session["UserName"].ToString();
                        vuSurname.Visible = true;
                        vuSurname.InnerText = Session["UserSurname"].ToString();
                        vuEmail.Visible = true;
                        vuEmail.InnerText = Session["UserEmail"].ToString();
                        vuPhoneNo.Visible = true;
                        vuPhoneNo.InnerText = Session["UserPhoneNo"].ToString();
                        btnRegister.Text = "View Invoices";
                    }
                }else if(Session["UserType"].ToString() == "MA")
                {
                    if(!regStaff)
                    {
                        if (edit)
                        {
                            pageHeading.InnerText = "Edit Profile";
                            hidePassword.Visible = false;
                            hideCPassword.Visible = false;
                            vhideSI.Visible = false;
                            btnRegister.Text = "Edit Profile";
                        }
                        else if (!edit)
                        {
                            pageHeading.InnerText = "My Profile";
                            uName.Visible = false;
                            uSurname.Visible = false;
                            uEmail.Visible = false;
                            uPhoneNo.Visible = false;
                            hidePassword.Visible = false;
                            hideCPassword.Visible = false;
                            vhideSI.Visible = false;
                            vuName.Visible = true;
                            vuName.InnerText = Session["UserName"].ToString();
                            vuSurname.Visible = true;
                            vuSurname.InnerText = Session["UserSurname"].ToString();
                            vuEmail.Visible = true;
                            vuEmail.InnerText = Session["UserEmail"].ToString();
                            vuPhoneNo.Visible = true;
                            vuPhoneNo.InnerText = Session["UserPhoneNo"].ToString();
                            btnRegister.Visible = false;
                            displayInvoices();
                        }
                    }
                    else
                    {
                        pageHeading.InnerText = "Register Staff";
                        hidePhoneNo.Visible = false;
                        hidePassword.Visible = false;
                        hideCPassword.Visible = false;
                        vhideSI.Visible = false;
                        btnRegister.Text = "Register Account";
                    }
                }
            }
        }
        private void displayInvoices()
        {
            if(Session["UserID"] != null)
            {
                userInvoices.Visible = true;
                int userID = int.Parse(Session["UserID"].ToString());
                var clientInvoices = client.getUserInvoice(userID);
                string display = "<h1>Invoices</h1>";
                if(clientInvoices.Count()>0)
                {
                    foreach (ServiceReference1.Invoice i in clientInvoices)
                    {
                        display += "<div class=\"singleInvoice\">"
                                + "<label for=\"\">Invoice #" + i.Id + "</label>"
                                + "<a href=\"Invoice.aspx?invoiceID=" + i.Id + "\">"
                                + "<button type=\"button\" class=\"btn btn-primary btn-sm btn-block\">"
                                + "<span class=\"glyphicon glyphicon-share-alt\"></span> View Invoice"
                                + "</button>"
                                + "</a>"
                                + "</div>";
                    }
                }else
                {
                    display += "There are no invoices in your account yet";
                }
                
                userInvoices.InnerHtml = display;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(Request.QueryString["viewEdit"] != null)
            {
                if(Session["UserType"].ToString() == "CU")
                {
                    if(edit)
                    {
                        int id = int.Parse(Session["UserID"].ToString());
                        string Name = uName.Value;
                        string Surname = uSurname.Value;
                        string Email = uEmail.Value;
                        string phoneNo = uPhoneNo.Value;
                        bool didUpdate = client.UpdateInfo(id, Name, Surname, Email, phoneNo, "CU");
                        if(didUpdate)
                        {
                            Session["UserName"] = uName.Value;
                            Session["UserSurname"] = uSurname.Value;
                            Session["UserEmail"] = uEmail.Value;
                            Session["UserPhoneNo"] = uPhoneNo.Value;
                            registerStatus.Visible = true;
                            registerStatus.InnerText = "Profile Sucessfully Edited";
                            registerStatus.Attributes.Add("style", "color: green");
                            Response.Redirect("Register.aspx?viewEdit=VIEW");
                        }else
                        {
                            registerStatus.Visible = true;
                            registerStatus.InnerText = "Unable to edit profile Try again";
                            registerStatus.Attributes.Add("style", "color: red");
                        }
                    }
                }
            }else
            {
                if(regStaff)
                {
                    string strName = uName.Value;
                    string strSurname = uSurname.Value;
                    string strEmail = uEmail.Value;
                    bool isStaff = client.registerStaff(strName, strSurname, strEmail, "MA");
                    if(isStaff)
                    {
                        registerStatus.Visible = true;
                        registerStatus.InnerText = "Staff Account Sucessfully Registered";
                        registerStatus.Attributes.Add("style", "color: green");
                    }else
                    {
                        registerStatus.Visible = true;
                        registerStatus.InnerText = "The Specified Details do not match any Registerd User!!Try Again";
                        registerStatus.Attributes.Add("style", "color: red");
                    }
                }else
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
                            registerStatus.Attributes.Add("style", "color: green");
                        }
                        else
                        {
                            registerStatus.Visible = true;
                            registerStatus.InnerText = "Did not register Try Again";
                            registerStatus.Attributes.Add("style", "color: red");
                        }
                    }
                    else
                    {
                        registerStatus.Visible = true;
                        registerStatus.InnerText = "Password did not match Confirm Password";
                        registerStatus.Attributes.Add("style", "color: red");
                    }
                }
            }
        }
    }
}