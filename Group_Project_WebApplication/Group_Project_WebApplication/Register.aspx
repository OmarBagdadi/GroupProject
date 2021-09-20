<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Group_Project_WebApplication.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Salon Register</title>
    <link rel="stylesheet" href="assets/css/Register.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="call-to-action">
            <div class="container">
              <div class="row">
                <div class="col-md-12">
                  <div class="inner-content">
                    <h1>Register</h1>
                    <div class="txtbox">
                        <label for="">First Name:</label>
                        <input type="text" placeholder="First Name" required>
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Last Name:</label>
                        <input type="text" placeholder="Last Name" required>
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Email:</label>
                        <input type="email" placeholder="example@gmail.com" required>
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Phone Number:</label>
                        <input type="email" placeholder="Phone Number">
                        <h6 hidden>Testing</h6>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Date of Birth:</label>
                        <input type="date" placeholder="Date of Brith">
                    </div>
            
                    <div class="txtbox">
                        <label for="">Password:</label>
                        <input type="password" placeholder="Password" required>
                    </div>
            
                    <div class="txtbox">
                        <label for="">Confirm Password:</label>
                        <input type="password" placeholder="Confirm Password" required>
                    </div>
            
                    <input type="submit" class="btnLogin" value="Register Account">
            
                    <div class="register">
                        <p>Already have an account? <a href="#">Sign In</a></p>
                    </div>

                    <div class="Invoices" hidden>
                      <h6>Invoice ID</h6>
                      <a href="Invoice.html">
                        <button type="button" class="btn btn-primary btn-sm btn-block">
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
</asp:Content>
