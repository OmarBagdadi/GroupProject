﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Group_Project_WebApplication.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Shopping Cart</title>
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

        <!-- Cart Starts here -->
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="cart-background"></div>
              <div class="inner-content">
                <section class="mt-5">
                  <div class="cart">
                    <div class="table-responsive">
                      <div class="btnContinue">
                        <button type="button" class="btn btn-primary btn-sm btn-block">
                          <span class="glyphicon glyphicon-share-alt"></span> Continue shopping
                        </button>
                      </div>
                        <table class="table">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col"class="text-white">Product</th>
                                    <th scope="col"class="text-white">Price</th>
                                    <th scope="col"class="text-white">Quantity</th>
                                    <th scope="col"class="text-white">Total</th>
                                    <th scope="col"class="text-white">Remove</th>
                                </tr>
                            </thead>
                            <tbody>
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
                                        <h6>R20.00</h6>
                                    </td>
                                    <td>
                                        <div class="counter">
                                            <input class="input-number"type="number"
                                            value="1"min="0"max="10">
                                        </div>
                                    </td>
                                    <td>
                                        <h6>R20.00</h6>
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
                                <!-- Cart item -->
                                <tr>
                                    <td>
                                        <div class="main">
                                            <div class="d-flex">
                            <!--W=145 H=98--> <img src="assets/images/HairsalonProducts/products/conditioner.jpg"alt="">
                                            </div>
                                            <div class="des">
                                                <p>Conditioner</p>
                                            </div>
                                        </div>
                                    </td>
                                    <td>
                                        <h6>R20.00</h6>
                                    </td>
                                    <td>
                                        <div class="counter">
                                            <input class="input-number"type="number"
                                            value="1"min="0"max="10">
                                        </div>
                                    </td>
                                    <td>
                                        <h6>R20.00</h6>
                                    </td>
                                    <td><button type="button">X</button></td>
                                </tr>
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
                                        <h6>R20.00</h6>
                                    </td>
                                    <td>
                                        <div class="counter">
                                            <input class="input-number" type="number"
                                            value="1"min="0"max="10">
                                        </div>
                                    </td>
                                    <td>
                                        <h6>R20.00</h6>
                                    </td>
                                    <td><button type="button">X</button></td>
                                </tr>
                                <!-- End of Cart Items -->
                            </tbody>
                        </table>
                    </div>
                  </div>
                </section>
                  <div class="col-lg-4 offset-lg-4">
                    <div class="checkout">
                        <ul>
                            <li class="subtotal">subtotal
                                <span>R60.00</span>
                            </li>
                            <li class="subtotal">Delivery
                              <!-- <input type="checkbox"> -->
                              <span>R60.00</span>
                            </li>
                            <li class="cart-total">Total
                            <span>R60.00</span></li>
                        </ul>
                        <a href="Checkout.html"class="proceed-btn">Proceed to Checkout</a>
                    </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        
      <!-- Cart Ends Here -->
</asp:Content>
