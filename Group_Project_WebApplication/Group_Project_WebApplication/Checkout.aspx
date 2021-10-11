<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="Group_Project_WebApplication.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Checkout </title>
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link rel="stylesheet" href="assets/css/Checkout.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Banner Starts Here -->
        <div class="banner header-text">
          <div class="owl-banner owl-carousel">
            <div>
              <div class="cart-banner"></div>
                <div class="text-content">
                  <h4>Cart</h4>
                  <h2>Checkout</h2>
                </div>
            </div>
          </div>
        </div>
        <!-- Banner Ends Here -->

        <div class="checkout">
            <h2>Checkout </h2>
            <div class="checkout-row">
                <div class="col-75">
                    <div class="checkout-container">
                        <form runat="server" id="validate" >
                            <div class="checkout-row">
                                <div class="col-50">
                                    <h3>Billing Address</h3>
                                    <label for="fname"><i class="fa fa-user"></i> Full Name</label>
                                    <input type="text" id="fname" name="fullname" placeholder="John Doe" required>
                                    <label for="email"><i class="fa fa-envelope"></i> Email</label>
                                    <input type="text" id="email" name="email" placeholder="johndoe@gmail.com" required>
                                    <label for="address"><i class="fa fa-address-card-o"></i> Address</label>
                                    <input runat="server" id="address" type="text" name="address" placeholder="123 SomeStreet" required>
                                    <label for="city"><i class="fa fa-institution"></i> City</label>
                                    <input runat="server" id="city" type="text" name="city" placeholder="Johannesburg" required>

                                    <div class="checkout-row">
                                        <div class="col-50">
                                            <label for="province">Province</label>
                                            <input runat="server" type="text" id="province" name="province" placeholder="Gauteng" required>
                                        </div>
                                        <div class="col-50">
                                            <label for="postalCode">Postal Code</label>
                                            <input runat="server" type="text" id="postalCode" name="postalCode" placeholder="1234" required>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-50">
                                    <h3>Payment</h3>
                                    <label for="fname">Accepted Cards</label>
                                    <div class="icon-container">
                                        <i class="fa fa-cc-visa" style="color:navy;"></i>
                                        <i class="fa fa-cc-amex" style="color:blue;"></i>
                                        <i class="fa fa-cc-mastercard" style="color:red;"></i>
                                        <i class="fa fa-cc-discover" style="color:orange;"></i>
                                    </div>

                                    <label for="cname">Name on Card</label>
                                    <input type="text" id="cname" name="cardname" placeholder="Visa"required>
                                    <label for="ccnum">Credit card number</label>
                                    <input type="text" id="ccnum" name="cardnumber" placeholder="1111-2222-3333-4444"required>
                                    <label for="expmonth">Exp Month</label>
                                    <input type="text" id="expmonth" name="expmonth" placeholder="September"required>
                                    <div class="checkout-row">
                                        <div class="col-50">
                                            <label for="expyear">Exp Year</label>
                                            <input type="text" id="expyear" name="expyear" placeholder="2021"required>
                                        </div>
                                        <div class="col-50">
                                            <label for="cvv">CVV</label>
                                            <input type="text" id="cvv" name="cvv" placeholder="352"required>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <asp:Button class="btn" ID="btnPurchase" runat="server" Text="Purchase" OnClick="btnPurchase_Click" />
                        </form>
                    </div>
                </div>
                <div class="col-25">
                    <div runat="server" id="checkOutInvoice" class="checkout-container">
                        <h4>Cart <span class="price" style="color:black"><i class="fa fa-shopping-cart"></i> <b>4</b></span></h4>
                        <p><a href="#">IPHONE 12 Pro Mac</a> <span class="price">$1500</span></p>
                        <p><a href="#">SAMSUNG S21</a> <span class="price">$1500</span></p>
                        <p><a href="#">OPPO F14</a> <span class="price">$1400</span></p>
                        <p><a href="#">HUAWEI 20 Mac</a> <span class="price">$1200</span></p>
                        <hr>
                        <p>SubTotal Including VAT<span class="price" style="color:black"><b>R12600</b></span></p>
                        <p>VAT <span class="price" style="color:black"><b>R12600</b></span></p>
                        <p>Discount <span class="price" style="color:black"><b>R12600</b></span></p>
                        <p>Shipping <span class="price" style="color:black"><b>R12600</b></span></p>
                        <p>Grand Total <span class="price" style="color:black"><b>R12600</b></span></p>
                    </div>
                </div>
            </div>
        </div>
<!-- script validate js -->
    <script>
        $('#validate').validate({
            roles: {
                fullname: {
                    required: true,
                },
                email: {
                    required: true,
                },
                address: {
                    required: true,
                },
                city: {
                    required: true,
                },
                province: {
                    required: true,
                },
                postalCode: {
                    required: true,
                },
                cardname: {
                    required: true,
                },
                cardnumber: {
                    required: true,
                },
                expmonth: {
                    required: true,
                },
                expyear: {
                    required: true,
                },
                cvv: {
                    required: true,
                },

            },
            messages: {
                fullname: "Please input full name*",
                email: "Please input email*",
                city: "Please input city*",
                address: "Please input address*",
                state: "Please input state*",
                zip: "Please input address*",
                cardname: "Please input card name*",
                cardnumber: "Please input card number*",
                expmonth: "Please input exp month*",
                expyear: "Please input exp year*",
                cvv: "Please input cvv*",
            },
        });
    </script>
</asp:Content>
