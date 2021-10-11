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
                            <button onclick="showPanel(0,'#f44336')">User Reports</button>
                            <button onclick="showPanel(1,'#f44336')">Product Reports</button>
                        </div>
                        <div class="tabPanel">
                            <div class="userGraph" id="columnchart_values" style="width: 1050px; height: 600px;"></div>
                            <div class="col-md-4">
                                <div class="product-item">
                                  <div class="down-content">
                                    <h4>Total Registered Users</h4>
                                    <p>Quantity: 25</p>
                                  </div>
                                </div>
                              </div>
                              
                        </div>
                        <div class="tabPanel">
                            <div class="userGraph" id="chart_values" style="width: 1050px; height: 600px;"></div>
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
    <script type="text/javascript" src="assets/js/loader.js"></script>
    <script type="text/javascript">
        google.charts.load("current", { packages: ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);
        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ["Element", "Users", { role: "style" }],
                ["Monday", 10, "#0033ff"],
                ["Teusday", 20, "#0033ff"],
                ["Wednesday", 30, "#0033ff"],
                ["Thursday", 45, "color: #0033ff"],
                ["Friday", 50, "color: #0033ff"],
                ["Saturday", 60, "color: #0033ff"],
                ["Sunday", 70, "color: #0033ff"]
            ]);

            var view = new google.visualization.DataView(data);
            view.setColumns([0, 1,
                {
                    calc: "stringify",
                    sourceColumn: 1,
                    type: "string",
                    role: "annotation"
                },
                2]);

            var options = {
                title: "Number of new Users in the week",
                width: 1050,
                height: 600,
                bar: { groupWidth: "95%" },
                legend: { position: "none" },
            };
            var chart = new google.visualization.ColumnChart(document.getElementById("columnchart_values"));
            chart.draw(view, options);
        }
    </script>
    <div runat="server" id="productGraph">
        <script type="text/javascript">
            google.charts.load("current", { packages: ['corechart'] });
            google.charts.setOnLoadCallback(drawChart);
            function drawChart() {
                var data = google.visualization.arrayToDataTable([
                    ["Element", "Users", { role: "style" }],
                    ["Hair Products", 10, "#0033ff"],
                    ["Hair Accessories", 20, "#0033ff"],
                    ["Hair Appliances", 30, "#0033ff"],
                    ["Total products Sold", 60, "#0033ff"]
                ]);

                var view = new google.visualization.DataView(data);
                view.setColumns([0, 1,
                    {
                        calc: "stringify",
                        sourceColumn: 1,
                        type: "string",
                        role: "annotation"
                    },
                    2]);

                var options = {
                    title: "Products Sold per Category",
                    width: 1050,
                    height: 600,
                    bar: { groupWidth: "95%" },
                    legend: { position: "none" },
                };
                var chart = new google.visualization.ColumnChart(document.getElementById("chart_values"));
                chart.draw(view, options);
            }
        </script>
    </div>
    

</asp:Content>