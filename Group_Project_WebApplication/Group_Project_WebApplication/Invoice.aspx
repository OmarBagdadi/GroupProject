<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="Group_Project_WebApplication.Invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Customer Invoice</title>
    <link rel="stylesheet" href="assets/css/Invoice.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Banner Starts Here -->
        <div class="banner header-text">
            <div>
                <div class="invoice-banner"></div>
                  <div class="text-content">
                    <h4>Invoice</h4>
                    <h2>Customer Invoice</h2>
                </div>
            </div>
        </div>
        <!-- Banner Ends Here -->

        <!-- Page Content -->
        <!--Code snippit taken from https://bbbootstrap.com/snippets/ecommerce-product-invoice-template-33361338 -->
        <div class="Invoice">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="inner-content">
                            <div class="offset-xl-2 col-xl-8 col-lg-12 col-md-12 col-sm-12 col-12 padding">
                                <div class="card">
                                    <div class="card-header p-4">
                                        <a class="pt-2 d-inline-block" href="Home.aspx" data-abc="true">SimplySalon.com</a>
                                        <div runat="server" id="invNumDate" class="float-right">
                                            <h3 class="mb-0">Invoice #BBB10234</h3>
                                            Date: 12 Jun,2019
                                        </div>
                                    </div>
                                    <div class="card-body">
                                        <div class="row mb-4">
                                            <div class="col-sm-6">
                                                <h5 class="mb-3">From:</h5>
                                                <h3 class="text-dark mb-1">SimplySalon</h3>
                                                <div>CRN Kingsway Avenue & University Road</div>
                                                <div>Aukland Park, Johannesburg 2092</div>
                                                <div>Email: simplysalon@gmail.com</div>
                                                <div>Phone: +27 11 123 4567</div>
                                            </div>
                                            <div runat="server" id="invAddress" class="col-sm-6 ">
                                                <h5 class="mb-3">To:</h5>
                                                <h3 class="text-dark mb-1">Customer Name</h3>
                                                <div>Customer Address</div>
                                                <div>Customer Address</div>
                                                <div>Email: customer@email.com</div>
                                                <div>Phone: customer Phone No.</div>
                                            </div>
                                        </div>
                                        <div class="table-responsive-sm">
                                            <table class="table table-striped">
                                                <thead>
                                                    <tr>
                                                        <th class="center">#</th>
                                                        <th>Item</th>
                                                        <th class="right">Price</th>
                                                        <th class="center">Qty</th>
                                                        <th class="right">Total</th>
                                                    </tr>
                                                </thead>
                                                <tbody runat="server" id="invProducts">
                                                    <tr>
                                                        <td class="center">1</td>
                                                        <td class="left strong">Iphone 10X</td>
                                                        <td class="right">$1500</td>
                                                        <td class="center">10</td>
                                                        <td class="right">$15,000</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="center">2</td>
                                                        <td class="left">Iphone 8X</td>
                                                        <td class="right">$1200</td>
                                                        <td class="center">10</td>
                                                        <td class="right">$12,000</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="center">3</td>
                                                        <td class="left">Samsung 4C</td>
                                                        <td class="right">$800</td>
                                                        <td class="center">10</td>
                                                        <td class="right">$8000</td>
                                                    </tr>
                                                    <tr>
                                                        <td class="center">4</td>
                                                        <td class="left">Google Pixel</td>
                                                        <td class="right">$500</td>
                                                        <td class="center">10</td>
                                                        <td class="right">$5000</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-4 col-sm-5">
                                            </div>
                                            <div class="col-lg-4 col-sm-5 ml-auto">
                                                <table class="table table-clear">
                                                    <tbody runat="server" id="invTotals">
                                                        <tr>
                                                            <td class="left">
                                                                <strong class="text-dark">Subtotal Including VAT</strong>
                                                            </td>
                                                            <td class="right">$28,809,00</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="left">
                                                                <strong class="text-dark">VAT (15%)</strong>
                                                            </td>
                                                            <td class="right">$2,304,00</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="left">
                                                                <strong class="text-dark">Discount (20%)</strong>
                                                            </td>
                                                            <td class="right">$5,761,00</td>
                                                        </tr>
                                                        <tr>
                                                            <td class="left">
                                                                <strong class="text-dark">Grand Total</strong> </td>
                                                            <td class="right">
                                                                <strong class="text-dark">$20,744,00</strong>
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card-footer bg-white">
                                        <p class="mb-0">SimplySalon.com, Aukland Park, Johannesburg, 2092</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
