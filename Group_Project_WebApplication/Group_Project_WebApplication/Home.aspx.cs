using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Home : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            SalonMaster.activePage = "Home";
            string addCart = "hidden";
            string editProduct = "hidden";
            string products = "<div class=\"col-md-12\">"
                            + "<div class=\"section-heading\">"
                            + "<h2>Latest Products</h2>"
                            + "<a href=\"Products.aspx\">view all products <i class=\"fa fa-angle-right\"></i></a>"
                            + "</div>"
                            + "</div>";
            if (Session["UserType"] != null)
            {
                if(Session["UserType"].ToString() == "CU")
                {
                    addCart = "";
                }else if(Session["UserType"].ToString() == "MA")
                {
                    addCart = "";
                    editProduct = "";
                }
            }
            var LP = client.getLatestProducts();
            foreach(Product p in LP)
            {
                
                products += "<div class=\"col-md-4\">"
                            + "<div class=\"product-item\">"
                            + "<a href=\"AboutProduct.aspx?prodID=" + p.Id + "\"><img src=\"" + p.ImageLocation + "\" alt=\"\"></a>"
                            + "<div class=\"down-content\">"
                            + "<a href=\"AboutProduct.aspx?prodID=" + p.Id + "\"><h4>" + p.Name + "</h4></a>"
                            + "<h6>R" + String.Format("{0:0.00}", p.Price) + "</h6>"
                            + "<p>Quantity: " + p.Quantity + "</p>"
                            + "<div class=\"rating\">"
                            + "<ul class=\"stars\">"
                            + "<li><i class=\"fa fa-star\"></i></li>"
                            + "<li><i class=\"fa fa-star\"></i></li>"
                            + "<li><i class=\"fa fa-star\"></i></li>"
                            + "<li><i class=\"fa fa-star\"></i></li>"
                            + "<li><i class=\"fa fa-star\"></i></li>"
                            + "</ul>"
                            + "<a href=\"AboutProduct.aspx?prodID=\"> <span>Reviews (24)</span></a>"
                            + "</div>"
                            + "<a href=\"AboutProduct.aspx?prodID=" + p.Id + "\" " + addCart + ">"
                            + "<button type=\"button\" class=\"btn btn-primary btn-sm btn-block\">"
                            + "<span class=\"glyphicon glyphicon-share-alt\"></span> Add to Cart"
                            + "</button>"
                            + "</a>"
                            + "<a href=\"AboutProduct.aspx?editProdID=" + p.Id + "\" " + editProduct + ">"
                            + "<button type=\"button\" class=\"btn btn-primary btn-sm btn-block\">"
                            + "<span class=\"glyphicon glyphicon-share-alt\"></span> Edit Product"
                            + "</button>"
                            + "</a>"
                            + "</div>"
                            + "</div>"
                            + "</div>";
            }
            latestProducts.InnerHtml = products;
        }
    }
}