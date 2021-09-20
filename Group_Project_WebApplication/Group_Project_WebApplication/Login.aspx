<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Group_Project_WebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Salon LogIn</title>
    <link rel="stylesheet" href="assets/css/Login.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="call-to-action">
            <div class="container">
              <div class="row">
                <div class="col-md-12">
                  <div class="inner-content">
                    <h1>Login</h1>
                    <div class="txtbox">
                        <label for="">Email:</label>
                        <input runat="server" id="uEmail" type="email" placeholder="example@gmail.com" required>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Password:</label>
                        <input runat="server" id="uPassword" type="password" placeholder="Password" required>
                    </div>
                    
                    <label runat="server" id="loginStatus" style="color: red; text-align: center;" for="" visible="false"></label>
                    <asp:Button class="btnLogin" ID="btnLogIn" runat="server" Text="Log In" OnClick="btnLogIn_Click" />

                    <div class="register">
                        <p>Dont have an account? <a href="#">Register</a></p>
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
