<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="AddRemoveProduct.aspx.cs" Inherits="Group_Project_WebApplication.AddRemoveProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Manage Products</title>
    <link rel="stylesheet" href="assets/css/Cart-style.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Banner Starts Here -->
        <div class="banner header-text">
          <div class="owl-banner owl-carousel">
            <div>
              <div class="cart-banner"></div>
                <div class="text-content">
                  <h4>Cart</h4>
                  <h2>Cart Products</h2>
                </div>
            </div>
          </div>
        </div>
        <!-- Banner Ends Here -->

        <!-- Page Content Starts here -->
    <div class="manage-product">
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="cart-background"></div>
              <div class="inner-content">
                <section class="mt-5">
                  <div class="cart">
                    <div class="table-responsive">
                        <h6 runat="server" id="userMessage"></h6>
                        <table class="table">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col"class="text-white">Image</th>
                                    <th scope="col"class="text-white">Name</th>
                                    <th scope="col"class="text-white">Description</th>
                                    <th scope="col"class="text-white">Unit Price</th>
                                    <th scope="col"class="text-white">Avaliable</th>
                                    <th scope="col"class="text-white">Edit/Remove</th>
                                </tr>
                            </thead>
                            <tbody runat="server" id="populatePage">
                              <!-- Cart item -->
                                <tr>
                                    <td>
                                        <div class="main">
                                            <div class="d-flex">
                            <!--W=145 H=98--> <img src="images/cart-1.jpg"alt="">
                                            </div>
                                            <div class="des">
                                                <p>lorem ipsum</p>
                                            </div>
                                        </div>
                                    </td>
                                    <td>
                                        <div><h6>R</h6><h6 id="prodPrice">50</h6></div>
                                    </td>
                                    <td>
                                        <div class="counter">
                                            <input id="Quantity" class="input-number"type="number" onchange="Total()"
                                            value="1"min="0"max="10">
                                        </div>
                                    </td>
                                    <td>
                                        <h6>R</h6><h6 id="prodTotal">20.00</h6>
                                    </td>
                                    <td>
                                      <button type="button" class="btn btn-primary btn-sm btn-block">
                                      <span class="glyphicon glyphicon-share-alt"></span> Edit Product
                                      </button>
                                      <button type="button" class="btn btn-primary btn-sm btn-block" style="background-color: #f33f3f;">
                                        <span class="glyphicon glyphicon-share-alt"></span> Remove Product
                                      </button>
                                    </td>
                                </tr>
                                
                                <!-- End of Table Items -->
                            </tbody>
                        </table>
                    </div>
                  </div>
                </section>
              </div>
            </div>
          </div>
        </div>
    </div>
        
      <!-- Content Ends Here -->
</asp:Content>
