<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="AboutProduct.aspx.cs" Inherits="Group_Project_WebApplication.AboutProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>About Product</title>
    <link rel="stylesheet" href="assets/css/About-Product.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
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
                    <!-- Snippet taken from: https://bootsnipp.com/snippets/56bAW -->
                    <div class="card">
                        <div class="container-fliud">
                            <div class="wrapper row">
                                <div runat="server" id="prodImage" class="preview col-md-6">
                                    <div class="preview-pic tab-content">
                                      <div class="tab-pane active" id="pic-1"><img runat="server" id="oldImage" src="http://placekitten.com/400/252" /></div>
                                      <input runat="server" id="newImage" type="file" accept=".jpg,.jpeg,.png,.jfif" visible="false">
                                    </div>
                                </div>
                                <div class="details col-md-6">
                                    <div runat="server" id="prodInfo">
                                        <h3 class="product-title"><input runat="server" id="newName" type="text" visible="false" required></h3>
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
                                        <p class="product-description"><textarea runat="server" id="newDesc" type="description" rows="5" cols="70" visible="false" required></textarea></p>
                                        <p class="product-description"><input runat="server" id="newQuantity" type="text" visible="false" required></p>
                                        <h4 class="price">current price: <span>R<input runat="server" id="newPrice" type="number" step="any" visible="false" required></span></h4>
                                        <p class="vote"><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>
                                    </div>
                                    <div><p runat="server" id="errorMessage" visible="false"></p></div>
                                    <div class="action">
                                        <asp:Button class="btn btn-primary btn-sm btn-block" ID="btnAddCart" runat="server" Text="Add to Cart" OnClick="btnAddCart_Click" />
                                        <asp:Button class="btn btn-primary btn-sm btn-block" ID="btnEditProduct" runat="server" Text="Edit Product" OnClick="btnEditProduct_Click" />
                                    </div>
                                </div>
                                <!--Snippet taken from: https://codepen.io/budb/pen/mddKgJw -->
                                <div runat="server" id="prodReviews" class="col-md-12">
                                    <h3 class="title">Reviews</h3>
                                    <div class="review">
                                       <div class="body-review">
                                          <div class="name-review">Nathan D.</div>
                                          <div class="place-review">Germany</div>
                                          <div class="rating">
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star-half"></i>
                                          </div>
                                          <div class="desc-review">Lorem ipsum dolor, sit amet consectetur adipisicing elit. Obcaecati eligendi suscipit illum officia ex eos.</div>
                                       </div>
                                    </div>
                                    <div class="review">
                                       <div class="body-review">
                                          <div class="name-review">Nathan D.</div>
                                          <div class="place-review">Germany</div>
                                          <div class="rating">
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star"></i>
                                             <i class="fa fa-star-half"></i>
                                          </div>
                                          <div class="desc-review">Lorem ipsum dolor, sit amet consectetur adipisicing elit. Obcaecati eligendi suscipit illum officia ex eos.</div>
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
    </form>
</asp:Content>
