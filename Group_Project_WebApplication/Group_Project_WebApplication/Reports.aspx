<%@ Page Title="" Language="C#" MasterPageFile="~/SalonMaster.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Group_Project_WebApplication.Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <title>Reports</title>
    <title>Reports</title>
    <script type="text/javascript" src="assets/js/reportgraphuser.js"></script>
    <script type="text/javascript">
        google.charts.load('current', {
            packages: ['corechart']
        });
    </script>
    <link rel="stylesheet" href="assets/css/report.css">
    <script type="text/javascript" src="reportgraphinventory.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- Code Snippet for the Bar Graph: < https://www.studentstutorial.com/html/google-chart-tutorial.php > --%>

    <div class="call-to-action">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div runat="server" id="isEdit" class="inner-content">


                        <div id="usercontainer" style="width: 550px; height: 400px; margin: 0 auto"></div>
                        <!-- Users Registered Graph -->
                        <script language="JavaScript">
                            function drawChart() {
                                /* Define the chart to be drawn.*/
                                var data = google.visualization.arrayToDataTable([
                                    ['Page Vist', 'Students Tutorial'],
                                    ['2012', 10000],
                                    ['2013', 23000],
                                    ['2014', 46000],
                                    ['2015', 49000],
                                    ['2016', 55000],
                                    ['2017', 100000]
                                ]);
                                var options = {
                                    title: 'Page visit per year',
                                    isStacked: true
                                };
                                /* Instantiate and draw the chart.*/
                                var chart = new google.visualization.BarChart(document.getElementById('usercontainer'));
                                chart.draw(data, options);
                            }
                            google.charts.setOnLoadCallback(drawChart);
                        </script>

                        <div>
                            <div id="inventorycontainer" style="width: 50%; height: 100%"></div>
                            <script>
                                anychart.onDocumentReady(function () {

                                    // set the data
                                    var data = {
                                        header: ["Name", "Death toll"],
                                        rows: [
                                            ["Hair Appliances", 15],
                                            ["Hair Products", 87],
                                            ["Hair Accessories", 65]
                                        ]
                                    };

                                    // create the chart
                                    var chart = anychart.bar();

                                    // add the data
                                    chart.data(data);

                                    // set the chart title
                                    chart.title("The deadliest earthquakes in the XXth century");

                                    // draw
                                    chart.container("inventorycontainer");
                                    chart.draw();
                                });
                            </script>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

<%--<div>
                            <table class="graph">
                                <caption>Inventory</caption>
                                <thead>
                                    <tr>
                                        <th scope="col">ITEMS</th>
                                        <th scope="col">CATEGORIES</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <!-- NB: Leave the style-height in percentage and the span/value without percentage -->
                                    <tr style="height: 85%">
                                        <th scope="row">HA</th>
                                        <td><span>85</span></td>
                                    </tr>
                                    <tr style="height: 23%">
                                        <th scope="row">HP</th>
                                        <td><span>23</span></td>
                                    </tr>
                                    <tr style="height: 17%">
                                        <th scope="row">HAP</th>
                                        <td><span>17</span></td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>--%>