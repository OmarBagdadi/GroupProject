using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Reports : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var getReport = client.getProductReport();
            totalProdsSold.InnerHtml = "Quantity: " + getReport.TotalProdsSold;
            totalProdsAvliable.InnerHtml = "Quantity: " + getReport.TotalProdsAvaliable;
            string displayReport = "<tr>"
                                + "<td><h6>Hair Accessories</h6></td>"
                                + "<td><h6>" + getReport.totalHA + "</h6></td>"
                                + "<td><h6>" + getReport.totalHASold + "</h6></td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td><h6>Hair Appliance</h6></td>"
                                + "<td><h6>" + getReport.totalHAP + "</h6></td>"
                                + "<td><h6>" + getReport.totalHAPSold + "</h6></td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td><h6>Hair Product</h6></td>"
                                + "<td><h6>" + getReport.totalHP + "</h6></td>"
                                + "<td><h6>" + getReport.totalHPSold + "</h6></td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td><h6>Total</h6></td>"
                                + "<td><h6>" + getReport.TotalProdsAvaliable + "</h6></td>"
                                + "<td><h6>" + getReport.TotalProdsSold + "</h6></td>"
                                + "</tr>";
            populateReportTable.InnerHtml = displayReport;
        }

        private void displayGraph(ProductReport prodReport)
        {
            string display = "<script type=\"text/javascript\">"
                            + "google.charts.load(\"current\", { packages: [\'corechart\'] });"
                            + "google.charts.setOnLoadCallback(drawChart);"
                            + "function drawChart() {"
                            + "var data = google.visualization.arrayToDataTable(["
                            + "[\"Element\", \"Users\", { role: \"style\" }],"
                            + "[\"Hair Products\", "+prodReport.totalHP+", \"#0033ff\"],"
                            + "[\"Hair Accessories\", "+prodReport.totalHA+", \"#0033ff\"],"
                            + "[\"Hair Appliances\", "+prodReport.totalHAP+", \"#0033ff\"],"
                            + "[\"Total Products \", "+prodReport.TotalProdsAvaliable+", \"#0033ff\"]"
                            + "]);"
                            + "var view = new google.visualization.DataView(data);"
                            + "view.setColumns([0, 1,"
                            + "{"
                            + "calc: \"stringify\","
                            + "sourceColumn: 1,"
                            + "type: \"string\","
                            + "role: \"annotation\""
                            + "},"
                            + "2]);"
                            + "var options = {"
                            + "title: \"Products Sold per Category\","
                            + "width: 1050,"
                            + "height: 600,"
                            + "bar: { groupWidth: \"95%\" },"
                            + "legend: { position: \"none\" },"
                            + "};"
                            + "var chart = new google.visualization.ColumnChart(document.getElementById(\"chart_values\"));"
                            + "chart.draw(view, options);"
                            + "}"
                            + "</script>";
            productGraph.InnerHtml = display;
        }
    }
}