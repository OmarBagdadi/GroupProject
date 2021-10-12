<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="AboutProduct.aspx.cs" Inherits="Group_Project_WebApplication.AboutProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>About Product</title>
    <link rel="stylesheet" href="assets/css/About-Product.css">
    <link rel="stylesheet" href="assets/css/Review.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <div class="banner header-text">
              <div>
                <div class="About-banner"></div>
                  <div class="text-content">
                    <h4>About Product</h4>
                    <h2>Product Information</h2>
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
                                      <input runat="server" id="newImage" type="file" accept=".jpg,.jpeg,.png,.jfif" visible="false" >
                                    </div>
                                </div>
                                <div class="details col-md-6">
                                    <div runat="server" id="prodInfo">
                                        <h3 class="product-title" runat="server" id="prodName"><input runat="server" id="newName" type="text" visible="false" required></h3>
                                        <select runat="server" id="addCategory" visible="false">
                                            <option value="HA">Hair Accessory</option>
                                            <option value="HAP">Hair Appliance</option>
                                            <option value="HP">Hair Product</option>
                                        </select>
                                        <p class="product-description" runat="server" id="prodDesc"><textarea runat="server" id="newDesc" type="description" rows="5" cols="60" visible="false" required></textarea></p>
                                        <p class="product-description" runat="server" id="prodAvaliable">Avaliable: <input runat="server" id="newQuantity" type="number" onkeydown="return false" visible="false" min="1" required></p>
                                        <p class="product-description" runat="server" id="hideQuantity">Quantity: <input runat="server" id="addQuan" type="number" value="1" min="1" onkeydown="return false" visible="false" required></p>
                                        <h4 class="price">current price: <span runat="server" id="currentPrice">R<input runat="server" id="newPrice" type="text" pattern="[0-9]+.[0-9]+" visible="false" required></span></h4>
                                        <p class="vote"><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>
                                    </div>
                                    <div><p runat="server" id="userMessage" visible="false"></p></div>
                                    <div class="action">
                                        <asp:Button class="btn btn-primary btn-sm btn-block" ID="btnAddCart" runat="server" Text="Add to Cart" OnClick="btnAddCart_Click" />
                                        <asp:Button class="btn btn-primary btn-sm btn-block" ID="btnEditProduct" runat="server" Text="Edit Product" OnClick="btnEditProduct_Click" />
                                        <asp:Button class="btn btn-primary btn-sm btn-block" ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
                                    </div>
                                </div>
                                <!--Snippet taken from: https://codepen.io/budb/pen/mddKgJw -->
                                <div runat="server" id="prodReviews" class="col-md-12">
                                    <h3 class="title">Reviews</h3>
                                    <div class="review">
                                       <div class="body-review">
                                          <div class="name-review">Nathan D.</div>
                                          <div class="place-review">Germany</div>
                                          <div class="desc-review">Lorem ipsum dolor, sit amet consectetur adipisicing elit. Obcaecati eligendi suscipit illum officia ex eos.</div>
                                       </div>
                                    </div>
                                    <div class="review">
                                       <div class="body-review">
                                          <div class="name-review">Nathan D.</div>
                                          <div class="place-review">Germany</div>
                                          <div class="desc-review">
                                              Lorem ipsum dolor, sit amet consectetur adipisicing elit. Obcaecati eligendi suscipit illum officia ex eos.</div>
                                       </div>
                                    </div>
                                </div>
                                <asp:Button  class="btn btn-primary btn-sm btn-block" style="margin-top: 20px" ID="btnAddReview" runat="server" Text="Add Review" OnClick="btnAddReview_Click" />
                                <!---->
                                <!-- Code snippet taken from https://www.codingnepalweb.com/star-rating-html-css-javascript/-->
                                <div runat="server" id="addRating" class="col-md-12" visible="false">
                                    <div class="review-container">
                                        <div class="frm">
                                            <div class="textarea">
                                            <textarea runat="server" id="userReview" cols="30" placeholder="Describe your experience.."></textarea>
                                            </div>
                                            <div class="btn">
                                            <asp:Button class="aspbutton" ID="btnPostReview" runat="server" Text="Post" OnClick="btnPostReview_Click" />
                                            </div>
                                        </div>
                                    </div>
                                    <!---->
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
