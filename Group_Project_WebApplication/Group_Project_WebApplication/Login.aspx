<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Group_Project_WebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Salon LogIn</title>
    <link rel="stylesheet" href="assets/css/Login.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="call-to-action">
            <div class="container">
              <div class="row">
                <div class="col-md-12">
                  <div class="inner-content">
                    <h1>Login</h1>
                    <div class="txtbox">
                        <label for="">Email:</label>
                        <input type="email" placeholder="example@gmail.com" required>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Password:</label>
                        <input type="password" placeholder="Password" required>
                    </div>
            
                    <input type="submit" class="btnLogin" value="Login">
            
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
</asp:Content>
