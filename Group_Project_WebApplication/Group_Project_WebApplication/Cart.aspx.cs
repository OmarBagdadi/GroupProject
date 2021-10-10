using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Cart : System.Web.UI.Page
    {
        string display;
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["removeCart"] != null)
            {

            }
            if (!IsPostBack)
            {
                display = "";
                populateCart.InnerHtml = display;
            }
            if (Session["UserID"] != null)
            {
                displayCart();
            }

        }

        private void displayCart()
        {
            double subTotal = 0;
            string displayDiscount = "";
            double discount = 0;
            double VAT = 0;
            double grandTotal = 0;
            string shippingFee = "R" + 60;
            foreach(ShoppingCart s in SalonMaster.cart)
            {
                Product p = client.getProduct(s.prodID);
                display += "<tr>"
                    + "<td>"
                    + "<div class=\"main\">"
                    + "<div class=\"d-flex\">"
                    + "<img src=\"" + p.ImageLocation + "\"alt=\"\">"
                    + "</div>"
                    + "<div class=\"des\">"
                    + "<p>" + p.Name + "</p>"
                    + "</div>"
                    + "</div>"
                    + "</td>"
                    + "<td>"
                    + "<div><h6>R</h6><h6 id=\"prodPrice\">" + String.Format("{0:0.00}",p.Price) + "</h6></div>"
                    + "</td>"
                    + "<td>"
                    + "<div class=\"counter\">"
                    + "<h6>"+s.Quantity+"</h6> "
                    + "</div>"
                    + "</td>"
                    + "<td>"
                    + "<h6>R" + String.Format("{0:0.00}",(p.Price*s.Quantity)) + "</h6>"
                    + "</td>"
                    + "<td>"
                    + "<a href=\"Cart.aspx?removeCartID="+p.Id+"\"><button type=\"button\" class=\"btn btn-primary btn-sm btn-block\" style=\"background-color: #f33f3f;\">"
                    + "<span class=\"glyphicon glyphicon-share-alt\"></span> Remove Product"
                    + "</button></a>"
                    + "</td>"
                    + "</tr>";
                subTotal += (double)(p.Price * s.Quantity);
            }
            if(subTotal > 1500)
            {
                discount = subTotal * (0.1);
                displayDiscount = "(10%)";
                shippingFee = "Free";
            }
            VAT = subTotal - ((subTotal) / (1.15));
            grandTotal = (subTotal - discount);
            string displayTotals = "<li class=\"subtotal\">Total Including VAT"
                                + "<div class =\"total\"><h6>R"+subTotal+"</h6></div>"
                                + "</li>"
                                + "<li class=\"subtotal\">VAT(15%)"
                                + "<div class =\"total\"><h6>R" + String.Format("{0:0.00}", VAT) + "</h6></div>"
                                + "</li>"
                                + "<li class=\"subtotal\">Discount" + displayDiscount
                                + "<div class =\"total\"><h6>R"+discount+"</h6></div>"
                                + "</li>"
                                + "<li class=\"subtotal\">Shipping Fee"
                                + "<div class =\"total\"><h6>"+ string.Format("{0:0.00}", shippingFee) +"</h6></div>"
                                + "</li>"
                                + "<li class=\"cart-total\">Total"
                                + "<div class =\"total\"><h6>R"+ string.Format("{0:0.00}", grandTotal) +"</h6></div>"
                                + "</li>";
            cartCalculations.InnerHtml = displayTotals;
            populateCart.InnerHtml = display;
        }
    }
}