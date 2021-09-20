<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Group_Project_WebApplication.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Salon Register</title>
    <link rel="stylesheet" href="assets/css/Register.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="call-to-action">
            <div class="container">
              <div class="row">
                <div class="col-md-12">
                  <div class="inner-content">
                    <h1>Register</h1>
                    <div class="txtbox">
                        <label for="">First Name:</label>
                        <input runat="server" id="uName" type="text" placeholder="First Name" required>
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Last Name:</label>
                        <input runat="server" id="uSurname" type="text" placeholder="Last Name" required>
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Email:</label>
                        <input runat="server" id="uEmail" type="email" placeholder="example@gmail.com" required>
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Phone Number:</label>
                        <input type="tel" runat="server" id="uPhoneNo" name="phone" placeholder="123 456 789" pattern="[0-9]{3}[0-9]{3}[0-9]{4}" required>
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Password:</label>
                        <input runat="server" id="uPassword" type="password" placeholder="Password" required>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Confirm Password:</label>
                        <input runat="server" id="uCPassword" type="password" placeholder="Confirm Password" required>
                    </div>
                    
                    <label runat="server" id="registerStatus" for="" visible="false"></label>

                    <asp:Button class="btnLogin" ID="btnRegister" runat="server" Text="Register Account" OnClick="btnRegister_Click" />

                    <div class="register">
                        <p>Already have an account? <a href="Login.aspx">Sign In</a></p>
                    </div>

                    <div class="Invoices" hidden>
                      <h6>Invoice ID</h6>
                      <a href="Invoice.aspx">
                        <button type="button" class="btn btn-primary btn-sm btn-block">
                        <asp:Button class="btn btn-primary btn-sm btn-block" ID="btnInvoice" runat="server" Text="Button" />
                        <span class="glyphicon glyphicon-share-alt"></span> View Invoice
                        </button>
                      </a>
                    </div>
            
                    <div class="return">
                        <a href="index.html">Return</a>
                    </div>
                  </div>
                </div>
              </div>
            </div>
        </div>
    </form>
</asp:Content>
