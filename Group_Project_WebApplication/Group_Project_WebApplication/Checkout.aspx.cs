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
                shipping = "R" + reqInvoice.ShippingFee; 
            }else
            {
                shipping = "Free";
            }
            foreach(ShoppingCart s in SalonMaster.cart)
            {
                var prodInfo = client.getProduct(s.prodID);
                products += "<p>" + prodInfo.Name + "  X " + s.Quantity + "<span class=\"price\">R" 
                         + string.Format("{0:0.00}", (s.Quantity * prodInfo.Price)) + "</span></p>";
            }
            string subtotal = string.Format("{0:0.00}",reqInvoice.Subtotal);
            string VAT = string.Format("{0:0.00}", reqInvoice.VAT);
            string discount = string.Format("{0:0.00}", reqInvoice.Discount);
            string grandTotal = string.Format("{0:0.00}", reqInvoice.GrandTotal);
            string display = "<h4>Cart <span class=\"price\" style=\"color:black\"><i class=\"fa fa-shopping-cart\"></i> <b>"+noCartItems+"</b></span></h4>"
                            + products
                            + "<hr>"
                            + "<p>SubTotal Including VAT<span class=\"price\" style=\"color:black\"><b>R"+subtotal+"</b></span></p>"
                            + "<p>VAT <span class=\"price\" style=\"color:black\"><b>R"+VAT+"</b></span></p>"
                            + "<p>Discount <span class=\"price\" style=\"color:black\"><b>R"+discount+"</b></span></p>"
                            + "<p>Shipping <span class=\"price\" style=\"color:black\"><b>"+shipping+"</b></span></p>"
                            + "<p>Grand Total <span class=\"price\" style=\"color:black\"><b>R"+grandTotal+"</b></span></p>";
            checkOutInvoice.InnerHtml = display;
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            int invoiceID = int.Parse(Request.QueryString["invoiceID"].ToString());
            int userID = int.Parse(Session["UserID"].ToString());
            string invAddress = address.Value + "#" + city.Value + "#" + province.Value + "#" + postalCode.Value; 
            client.paidInvoice(invoiceID,invAddress);
            int totalHASold = 0;
            int totalHPSold = 0;
            int totalHAPSold = 0;
            foreach (ShoppingCart s in SalonMaster.cart)
            {
                var getProd = client.getProduct(s.prodID);
                if(getProd.Category.Equals("HA"))
                {
                    totalHASold = s.Quantity;
                }else if (getProd.Category.Equals("HP"))
                {
                    totalHPSold = s.Quantity;
                }else if (getProd.Category.Equals("HAP"))
                {
                    totalHAPSold = s.Quantity;
                }
                client.updateProductQuantity(s.prodID, s.Quantity);
            }
            client.updateProductReport(totalHASold, totalHPSold, totalHAPSold);
            SalonMaster.cart.Clear();
            client.clearCart(userID);
            Response.Redirect("Invoice.aspx?invoiceID="+invoiceID);
        }
    }
}