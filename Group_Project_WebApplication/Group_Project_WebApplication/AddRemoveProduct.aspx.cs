using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class AddRemoveProduct : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["removeProdID"] != null)
            {
                int removeID = int.Parse(Request.QueryString["removeProdID"].ToString());
                bool isRemoved = client.removeProduct(removeID);
                if(isRemoved)
                {
                    userMessage.Attributes.Add("color", "lawngreen");
                    userMessage.InnerHtml = "Product Sucessfully Removed";
                }else
                {
                    userMessage.Attributes.Add("color", "red");
                    userMessage.InnerHtml = "Something went wrong. Product was not removed";
                }
            }
            if(Session["UserType"] != null)
            {
                if(Session["UserType"].ToString() == "MA")
                {
                    displayProducts();
                }else
                {
                    Response.Redirect("Home.aspx");
                }
            }else
            {
                Response.Redirect("Home.aspx");
            }
        }

        private void displayProducts()
        {
            string display = "";
            var allProducts = client.getProducts();
            display += "<tr><td></td><td></td><td><a href=\"AboutProduct.aspx?addProd=1\"><button type=\"button\" class=\"btn btn-primary btn-sm btn-block\">"
                    + "<span class=\"glyphicon glyphicon-share-alt\"></span> Add Product"
                    + "</button></a></td></tr>";
            foreach (Product p in allProducts)
            {
                display += "<tr>"
                        + "<td>"
                        + "<div class=\"main\">"
                        + "<div class=\"d-flex\">"
                        + "<img src=\""+p.ImageLocation+"\"alt=\"\">"
                        + "</div>"
                        + "</div>"
                        + "</td>"
                        + "<td>"
                        + "<h6> "+p.Name+"</h6>"
                        + "</td>"
                        + "<td>"
                        + "<div class=\"des\">"
                        + "<p>" + p.Description + "</p>"
                        + "</div>"
                        + "</td>"
                        + "<td>"
                        + "<h6>R"+String.Format("{0:0.00}",p.Price)+"</h6>"
                        + "</td>"
                        + "<td>"
                        + "<h6>"+p.Quantity+"</h6>"
                        + "</td>"
                        + "<td>"
                        + "<a href=\"AboutProduct.aspx?editProdID=" + p.Id + "\"><button type=\"button\" class=\"btn btn-primary btn-sm btn-block\">"
                        + "<span class=\"glyphicon glyphicon-share-alt\"></span> Edit Product"
                        + "</button></a>"
                        + "<a href=\"AddRemoveProduct.aspx?removeProdID=" + p.Id + "\"><button type=\"button\" class=\"btn btn-primary btn-sm btn-block\" style=\"background-color: #f33f3f;\">"
                        + "<span class=\"glyphicon glyphicon-share-alt\"></span> Remove Product"
                        + "</button></a>"
                        + "</td>"
                        + "</tr>";
            }
            populatePage.InnerHtml = display;
        }
    }
}