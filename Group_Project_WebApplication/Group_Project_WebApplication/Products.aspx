<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Group_Project_WebApplication.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Salon Products</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Banner Start -->
    <div class="page-banner">
      <div class="page-heading products-heading header-text">
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="text-content">
                <h4>new arrivals</h4>
                <h2>Salon products</h2>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- Banner End -->

    <!-- Page Content -->
    <div class="products">
      <div class="container">
        <div class="container-background"></div>
        <div class="row">
          <div class="col-md-12">
            <div class="filters">
              <ul>
                  <li class="active" data-filter="*">All Products</li>
                  <li data-filter=".des">Featured</li>
                  <li data-filter=".dev">Flash Deals</li>
                  <li data-filter=".gra">Last Minute</li>
              </ul>
            </div>
          </div>
          <div class="col-md-12">
            <div class="filters-content">
                <div class="owl-banner owl-carousel">
                    <div class="row grid">
                        <div class="col-lg-4 col-md-4 all des">
                          <div class="product-item">
                              <a href="AboutProduct.html"><img src="assets/images/product_01.jpg" alt=""></a>
                              <div class="down-content">
                              <a href="#"><h4>Tittle goes here</h4></a>
                              <h6>$25.75</h6>
                              <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                              <div class="rating">
                                  <ul class="stars">
                                  <li><i class="fa fa-star"></i></li>
                                  <li><i class="fa fa-star"></i></li>
                                  <li><i class="fa fa-star"></i></li>
                                  <li><i class="fa fa-star"></i></li>
                                  <li><i class="fa fa-star"></i></li>
                                  </ul>
                                  <a href="#"> <span>Reviews (24)</span></a>
                              </div>
                              <a href="Cart.html">
                                  <button type="button" class="btn btn-primary btn-sm btn-block">
                                  <span class="glyphicon glyphicon-share-alt"></span> Add to Cart
                              </button>
                              </a>
                              <a href="AboutProduct.html">
                                  <button type="button" class="btn btn-primary btn-sm btn-block">
                                  <span class="glyphicon glyphicon-share-alt"></span> Edit Product
                              </button>
                              </a>
                              </div>
                          </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all dev">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_02.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$16.75</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (24)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all gra">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_03.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$32.50</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (36)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all gra">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_04.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$24.60</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (48)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all dev">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_05.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$18.75</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (60)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all des">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_06.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$12.50</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (72)</span>
                            </div>
                        </div>
                        </div>
                    </div>
                    <div class="row grid">
                        <div class="col-lg-4 col-md-4 all des">
                        <div class="product-item">
                            <a href="AboutProduct.html"><img src="assets/images/product_01.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$25.75</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <div class="rating">
                                <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                </ul>
                                <a href="#"> <span>Reviews (24)</span></a>
                            </div>
                            <a href="Cart.html">
                                <button type="button" class="btn btn-primary btn-sm btn-block">
                                <span class="glyphicon glyphicon-share-alt"></span> Add to Cart
                            </button>
                            </a>
                            <a href="AboutProduct.html">
                                <button type="button" class="btn btn-primary btn-sm btn-block">
                                <span class="glyphicon glyphicon-share-alt"></span> Edit Product
                            </button>
                            </a>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all dev">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_02.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$16.75</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (24)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all gra">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_03.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$32.50</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (36)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all gra">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_04.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$24.60</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (48)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all dev">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_05.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$18.75</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (60)</span>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-4 col-md-4 all des">
                        <div class="product-item">
                            <a href="#"><img src="assets/images/product_06.jpg" alt=""></a>
                            <div class="down-content">
                            <a href="#"><h4>Tittle goes here</h4></a>
                            <h6>$12.50</h6>
                            <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                            <ul class="stars">
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                                <li><i class="fa fa-star"></i></li>
                            </ul>
                            <span>Reviews (72)</span>
                            </div>
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
