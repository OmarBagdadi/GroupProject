﻿<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="AboutProduct.aspx.cs" Inherits="Group_Project_WebApplication.AboutProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>About Product</title>
    <link rel="stylesheet" href="assets/css/About-Product.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="banner header-text">
            <div class="owl-banner owl-carousel">
              <div>
                <div class="About-banner"></div>
                  <div class="text-content">
                    <h4>About Product</h4>
                    <h2>Product Information</h2>
                  </div>
              </div>
            </div>
          </div>
          <!-- Banner Ends Here -->

        <!-- Page Content -->
        <div class="container">
            <div class="row">
              <div class="col-md-12">
                <div class="inner-content">
                    <div class="card">
                        <div class="container-fliud">
                            <div class="wrapper row">
                                <div class="preview col-md-6">
                                    
                                    <div class="preview-pic tab-content">
                                      <div class="tab-pane active" id="pic-1"><img src="http://placekitten.com/400/252" /></div>
                                      <div class="tab-pane" id="pic-2"><img src="http://placekitten.com/400/252" /></div>
                                      <div class="tab-pane" id="pic-3"><img src="http://placekitten.com/400/252" /></div>
                                      <div class="tab-pane" id="pic-4"><img src="http://placekitten.com/400/252" /></div>
                                      <div class="tab-pane" id="pic-5"><img src="http://placekitten.com/400/252" /></div>
                                    </div>
                                    <ul class="preview-thumbnail nav nav-tabs">
                                      <li class="active"><a data-target="#pic-1" data-toggle="tab"><img src="http://placekitten.com/200/126" /></a></li>
                                      <li><a data-target="#pic-2" data-toggle="tab"><img src="http://placekitten.com/200/126" /></a></li>
                                      <li><a data-target="#pic-3" data-toggle="tab"><img src="http://placekitten.com/200/126" /></a></li>
                                      <li><a data-target="#pic-4" data-toggle="tab"><img src="http://placekitten.com/200/126" /></a></li>
                                      <li><a data-target="#pic-5" data-toggle="tab"><img src="http://placekitten.com/200/126" /></a></li>
                                    </ul>
                                    
                                </div>
                                <div class="details col-md-6">
                                    <h3 class="product-title">men's shoes fashion</h3>
                                    <div class="rating">
                                        <div class="stars">
                                            <span class="fa fa-star checked"></span>
                                            <span class="fa fa-star checked"></span>
                                            <span class="fa fa-star checked"></span>
                                            <span class="fa fa-star"></span>
                                            <span class="fa fa-star"></span>
                                        </div>
                                        <span class="review-no">41 reviews</span>
                                    </div>
                                    <p class="product-description">Suspendisse quos? Tempus cras iure temporibus? Eu laudantium cubilia sem sem! Repudiandae et! Massa senectus enim minim sociosqu delectus posuere.</p>
                                    <h4 class="price">current price: <span>$180</span></h4>
                                    <p class="vote"><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>
                                    <div class="action">
                                        <button class="add-to-cart btn btn-default" type="button">add to cart</button>
                                        <button class="add-to-cart btn btn-default" type="button">Edit Product</button>
                                        <button class="like btn btn-default" type="button"><span class="fa fa-heart"></span></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
              </div>
            </div>
        </div>
</asp:Content>
