using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Products : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        string isManager = "hidden";
        string isCustomer = "hidden";
       
        protected void Page_Load(object sender, EventArgs e)
        {
            SalonMaster.activePage = "Products";
            btnAllProducts.Attributes.Add("style","border-bottom: 3px solid #f33f3f");
            if(Session["UserType"] != null)
            {
                if(Session["UserType"].ToString() == "CU")
                {
                    isCustomer = "";
                }else if(Session["UserType"].ToString() == "MA")
                {
                    isCustomer = "";
                    isManager = "";
                }
            }
            var prods = client.getProducts();
            products.InnerHtml = populatePage(prods);
        }

        protected void btnAllProducts_Click(object sender, EventArgs e)
        {
            btnAllProducts.Attributes.Add("style", "border-bottom: 3px solid #f33f3f");
            btnHairAcc.Attributes.Remove("style");
            btnHairApp.Attributes.Remove("style");
            btnHairProd.Attributes.Remove("style");
            var prods = client.getProducts();
            products.InnerHtml = populatePage(prods);
        }

        protected void btnHairApp_Click(object sender, EventArgs e)
        {
            btnHairApp.Attributes.Add("style", "border-bottom: 3px solid #f33f3f");
            btnAllProducts.Attributes.Remove("style");
            btnHairProd.Attributes.Remove("style");
            btnHairAcc.Attributes.Remove("style");
            var hairAppProds = client.getHairApp();
            products.InnerHtml = populatePage(hairAppProds);
        }

        protected void btnHairProd_Click(object sender, EventArgs e)
        {
            btnHairProd.Attributes.Add("style", "border-bottom: 3px solid #f33f3f");
            btnAllProducts.Attributes.Remove("style");
            btnHairApp.Attributes.Remove("style");
            btnHairAcc.Attributes.Remove("style");
            var hairProds = client.getHairProd();
            products.InnerHtml = populatePage(hairProds);
        }

        protected void btnHairAcc_Click(object sender, EventArgs e)
        {
            btnHairAcc.Attributes.Add("style", "border-bottom: 3px solid #f33f3f");
            btnAllProducts.Attributes.Remove("style");
            btnHairApp.Attributes.Remove("style");
            btnHairProd.Attributes.Remove("style");
            var hairAccProds = client.getHairAcc();
            products.InnerHtml = populatePage(hairAccProds);
        }

        private string populatePage(dynamic products)
        {
            string display = "";
            string page = "";
            int index = 0;
            foreach (Product p in products)
            {
                index++;
                page += "<div class=\"col-lg-4 col-md-4 all \">"
                        + "<div class=\"product-item\">"
                        + "<a href=\"AboutProduct.aspx?prodID=" + p.Id + "\"><img src=\"" + p.ImageLocation + "\" alt=\"\"></a>"
                        + "<div class=\"down-content\">"
                        + "<a href=\"AboutProduct.aspx?prodID=" + p.Id + "\"><h4>" + p.Name + "</h4></a>"
                        + "<h6>R" + String.Format("{0:0.00}",p.Price) + "</h6>"
                        + "<p>Quantity: " + p.Quantity + "</p>"
                        + "<div class=\"rating\">"
                        + "<a href=\"AboutProduct.aspx?prodID=" + p.Id + "\"> <span>Reviews (24)</span></a>"
                        + "</div>"
                        + "<a href=\"AboutProduct.aspx?prodID=" + p.Id + "\">"
                        + "<button type=\"button\" class=\"btn btn-primary btn-sm btn-block\" " + isCustomer + ">"
                        + "<span class=\"glyphicon glyphicon-share-alt\"></span> Add to Cart"
                        + "</button>"
                        + "</a>"
                        + "<a href=\"AboutProduct.aspx?editProdID=" + p.Id + "\">"
                        + "<button type=\"button\" class=\"btn btn-primary btn-sm btn-block\" " + isManager + ">"
                        + "<span class=\"glyphicon glyphicon-share-alt\"></span> Edit Product"
                        + "</button>"
                        + "</a>"
                        + "</div>"
                        + "</div>"
                        + "</div>";
                if (index == 6)
                {
                    display += "<div class=\"row grid\">" + page
                            + "</div>";
                    page = "";
                    index = 0;
                }
            }
            if (index != 0)
            {
                display += "<div class=\"row grid\">" + page
                            + "</div>";
                page = "";
                index = 0;
            }
            return display;
        }
    }
}