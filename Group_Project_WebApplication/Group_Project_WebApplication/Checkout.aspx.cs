using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Checkout : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"] != null)
            {
                int userId = int.Parse(Session["UserID"].ToString());
                if(Request.QueryString["invoiceID"] != null)
                {
                    int invoiceID = int.Parse(Request.QueryString["invoiceID"].ToString());
                    ServiceReference1.Invoice reqInvoice = client.getInvoice(invoiceID);
                    displayCheckoutItems(reqInvoice);
                }
            }
            else
            {
                Response.Redirect(Request.UrlReferrer.ToString());
            }
        }

        private void displayCheckoutItems(ServiceReference1.Invoice reqInvoice)
        {
            int noCartItems = SalonMaster.cart.Count();
            string products = "";
            string shipping = "";
            if(reqInvoice.ShippingFee > 0)
            {
                //shipping = 
            }
            foreach(ShoppingCart s in SalonMaster.cart)
            {
                var prodInfo = client.getProduct(s.prodID);
                products += "<p>" + prodInfo.Name + "  X " + s.Quantity + "<span class=\"price\">R" 
                         + string.Format("{0:0.00}", (s.Quantity * prodInfo.Price)) + "</span></p>";
            }
            string display = "<h4>Cart <span class=\"price\" style=\"color:black\"><i class=\"fa fa-shopping-cart\"></i> <b>"+noCartItems+"</b></span></h4>"
                            + products
                            + "<hr>"
                            + "<p>SubTotal Including VAT<span class=\"price\" style=\"color:black\"><b>R"+reqInvoice.Subtotal+"</b></span></p>"
                            + "<p>VAT <span class=\"price\" style=\"color:black\"><b>R"+reqInvoice.VAT+"</b></span></p>"
                            + "<p>Discount <span class=\"price\" style=\"color:black\"><b>R"+reqInvoice.Discount+"</b></span></p>"
                            + "<p>Shipping <span class=\"price\" style=\"color:black\"><b>R"+reqInvoice.ShippingFee+"</b></span></p>"
                            + "<p>Grand Total <span class=\"price\" style=\"color:black\"><b>R"+reqInvoice.GrandTotal+"</b></span></p>";
            checkOutInvoice.InnerHtml = display;
        }
    }
}