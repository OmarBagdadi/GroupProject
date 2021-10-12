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
            client.updateProductReport();
            var getReport = client.getProductReport();
            totalProdsSold.InnerHtml = "Quantity: " + getReport.TotalProdsSold;
            totalProdsAvliable.InnerHtml = "Quantity: " + getReport.TotalProdsAvaliable;
            string displayReport = "<tr>"
                                + "<td><h6>Hair Accessories</h6></td>"
                                + "<td><h6>" + getReport.totalHA + "</h6></td>"
                                + "<td><h6>" + getReport.totalHASold + "</h6></td>"
                                + "<td><h6>R" + String.Format("{0:0.00}", getReport.totalHAearnings) + "</h6></td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td><h6>Hair Appliance</h6></td>"
                                + "<td><h6>" + getReport.totalHAP + "</h6></td>"
                                + "<td><h6>" + getReport.totalHAPSold + "</h6></td>"
                                + "<td><h6>R" + String.Format("{0:0.00}", getReport.totalHPearnings) + "</h6></td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td><h6>Hair Product</h6></td>"
                                + "<td><h6>" + getReport.totalHP + "</h6></td>"
                                + "<td><h6>" + getReport.totalHPSold + "</h6></td>"
                                + "<td><h6>R" + String.Format("{0:0.00}", getReport.totalHAPearnings) + "</h6></td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td><h6>Total</h6></td>"
                                + "<td><h6>" + getReport.TotalProdsAvaliable + "</h6></td>"
                                + "<td><h6>" + getReport.TotalProdsSold + "</h6></td>"
                                + "<td><h6>R" + String.Format("{0:0.00}",getReport.totalEarnings) + "</h6></td>"
                                + "</tr>";
            populateReportTable.InnerHtml = displayReport;
        }
    }
}