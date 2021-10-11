using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Invoice : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserID"] != null)
            {
                if(Request.QueryString["invoiceID"] != null)
                {
                    int invoiceID = int.Parse(Request.QueryString["invoiceID"].ToString());
                    ServiceReference1.Invoice reqInvoice = client.getInvoice(invoiceID);
                    displayInvoice(reqInvoice);
                }else
                {
                    Response.Redirect(Request.UrlReferrer.ToString());
                }
            }
            else
            {
                Response.Redirect(Request.UrlReferrer.ToString());
            }
        }

        private void displayInvoice(ServiceReference1.Invoice reqInvoice)
        {
            string userName = Session["UserName"].ToString();
            string userEmail = Session["UserEmail"].ToString();
            string userPhone = Session["UserPhoneNo"].ToString();
            int invoiceNo = reqInvoice.Id;
            DateTime date = (DateTime)reqInvoice.Date;
            string[] address = reqInvoice.Address.Split('#');
            string[] prods = reqInvoice.Products.Split('#');
            string displayInvoiceHead = "<h3 class=\"mb-0\">Invoice #"+invoiceNo+"</h3>"
                                        + "Date: " + date.Date;
            string displayAddress = "<h5 class=\"mb-3\">To:</h5>"
                                + "<h3 class=\"text-dark mb-1\">"+userName+"</h3>"
                                + "<div>"+address[0]+"</div>"
                                + "<div>"+address[1]+"</div>"
                                + "<div>Email: "+userEmail+"</div>"
                                + "<div>Phone: "+userPhone+"</div>";
            string displayProducts = "";
            int index = 0;
            foreach(string s in prods)
            {
                index++;
                if(!s.Equals(""))
                {
                    string[] cartItem = s.Split(' ');
                    int prodID = int.Parse(cartItem[0]);
                    int Quantity = int.Parse(cartItem[1]);
                    var prod = client.getProduct(prodID);
                    displayProducts += "<tr>"
                                    + "<td class=\"center\">"+index+"</td>"
                                    + "<td class=\"left strong\">" + prod.Name + "</td>"
                                    + "<td class=\"right\">R" + String.Format("{0:0.00}", prod.Price) + "</td>"
                                    + "<td class=\"center\">" + Quantity + "</td>"
                                    + "<td class=\"right\">R" + String.Format("{0:0.00}", (prod.Price * Quantity)) + "</td>"
                                    + "</tr>";
                }
            }
            string shipping = "";
            if(reqInvoice.ShippingFee > 0)
            {
                shipping = "R" + String.Format("{0:0.00}", reqInvoice.ShippingFee);
            }else
            {
                shipping = "Free";
            }
            string displayTotals = "<tr>"
                                + "<td class=\"left\">"
                                + "<strong class=\"text-dark\">Subtotal Including VAT</strong>"
                                + "</td>"
                                + "<td class=\"right\">R"+ String.Format("{0:0.00}", reqInvoice.Subtotal) + "</td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td class=\"left\">"
                                + "<strong class=\"text-dark\">VAT (15%)</strong>"
                                + "</td>"
                                + "<td class=\"right\">R"+ String.Format("{0:0.00}", reqInvoice.VAT) + "</td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td class=\"left\">"
                                + "<strong class=\"text-dark\">Discount </strong>"
                                + "</td>"
                                + "<td class=\"right\">R"+ String.Format("{0:0.00}", reqInvoice.Discount) + "</td>"
                                + "</tr>"
                                + "<tr>"
                                + "<td class=\"left\">"
                                + "<strong class=\"text-dark\">Shipping </strong>"
                                + "</td>"
                                + "<td class=\"right\">" + shipping + "</td>"
                                + "</tr>"
                                + "<tr>"
                                + "<tr>"
                                + "<td class=\"left\">"
                                + "<strong class=\"text-dark\">Grand Total</strong> </td>"
                                + "<td class=\"right\">"
                                + "<strong class=\"text-dark\">R"+ String.Format("{0:0.00}", reqInvoice.GrandTotal) + "</strong>"
                                + "</td>"
                                + "</tr>";
            invNumDate.InnerHtml = displayInvoiceHead;
            invAddress.InnerHtml = displayAddress;
            invProducts.InnerHtml = displayProducts;
            invTotals.InnerHtml = displayTotals;

        }
    }
}