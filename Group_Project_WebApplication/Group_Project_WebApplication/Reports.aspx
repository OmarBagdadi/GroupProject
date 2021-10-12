<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Group_Project_WebApplication.Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Reports</title>
    <link rel="stylesheet" type="text/css" href="assets/css/Reports.css">
    <link rel="stylesheet" href="assets/css/Cart-style.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Code Snippet for the Bar Graph: < https://www.studentstutorial.com/html/google-chart-tutorial.php > --%>

    <!-- Banner Starts Here -->
         <div class="banner header-text">
              <div>
                <div class="Reports-banner"></div>
                  <div class="text-content">
                    <h4>Reports</h4>
                    <h2>Website Statistics</h2>
                  </div>
              </div>
          </div>
          <!-- Banner Ends Here -->
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                <div class="inner-content">
                    <div class="tabContainer">
                        <div class="buttonContainer">
                            <button onclick="showPanel(0,'white')">Product Reports</button>
                        </div>
                        <div class="tabPanel">
                                <div class="col-md-4">
                                    <div class="product-item">
                                    <div class="down-content">
                                        <h4>Total Products Sold</h4>
                                        <p runat="server" id="totalProdsSold">Quantity: 25</p>
                                    </div>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="product-item">
                                    <div class="down-content">
                                        <h4>Total Products Avaliable</h4>
                                        <p runat="server" id="totalProdsAvliable">Quantity: 25</p>
                                    </div>
                                    </div>
                                </div>
                             <table class="table">
                            <thead class="thead-dark">
                                <tr>
                                    <th scope="col"class="text-white">Product Category</th>
                                    <th scope="col"class="text-white">Avaliable</th>
                                    <th scope="col"class="text-white">Sold</th>
                                    <th scope="col"class="text-white">Earnings</th>
                                </tr>
                            </thead>
                            <tbody runat="server" id="populateReportTable">
                                <tr>
                                    <td><h6>Hair Accessories</h6></td>
                                    <td><h6>50</h6></td>
                                    <td><h6>50</h6></td>
                                </tr>
                                <tr>
                                    <td><h6>Hair Appliance</h6></td>
                                    <td><h6>50</h6></td>
                                    <td><h6>50</h6></td>
                                </tr>
                                <tr>
                                    <td><h6>Hair Product</h6></td>
                                    <td><h6>50</h6></td>
                                    <td><h6>50</h6></td>
                                </tr>
                            </tbody>
                        </table>
                        </div>
                    </div>
                </div>
                </div>
            </div>
            </div>
    <script type="text/javascript" src="assets/js/ReportTabs.js"></script>
    
</div>
    

</asp:Content>