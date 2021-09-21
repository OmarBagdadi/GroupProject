using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class AboutProduct : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["editProdID"] != null)
            {
                btnAddCart.Visible = false;
                int productID = int.Parse(Request.QueryString["editProdID"].ToString());
                var editP = client.getProduct(productID);
                newImage.Visible = true;
                newName.Visible = true;
                newDesc.Visible = true;
                newQuantity.Visible = true;
                newPrice.Visible = true;
                oldImage.Src = editP.ImageLocation;
                newName.Value = editP.Name;
                newDesc.Value = editP.Description;
                newQuantity.Value = editP.Quantity.ToString();
                newPrice.Value = editP.Price.ToString();
            }
            else
            {
                if (Request.QueryString["prodID"] != null)
                {
                    if (Session["UserType"] != null)
                    {
                        if (Session["UserType"].ToString() == "CU")
                        {
                            btnAddCart.Visible = true;
                            btnEditProduct.Visible = false;
                        }
                        else if (Session["UserType"].ToString() == "MA")
                        {
                            btnAddCart.Visible = true;
                            btnEditProduct.Visible = true;
                        }
                    }
                    int productID = int.Parse(Request.QueryString["prodID"].ToString());
                    var product = client.getProduct(productID);
                    string PImage = "<div class=\"preview-pic tab-content\">"
                                        + "<div class=\"tab-pane active\" id=\"pic-1\"><img src=\"" + product.ImageLocation + "\" /></div>"
                                        + "</div>";
                    prodImage.InnerHtml = PImage;
                    string PInfo = "<h3 class=\"product-title\">" + product.Name + "</h3>"
                                    + "<div class=\"rating\">"
                                    + "<div class=\"stars\">"
                                    + "<span class=\"fa fa-star checked\"></span>"
                                    + "<span class=\"fa fa-star checked\"></span>"
                                    + "<span class=\"fa fa-star checked\"></span>"
                                    + "<span class=\"fa fa-star\"></span>"
                                    + "<span class=\"fa fa-star\"></span>"
                                    + "</div>"
                                    + "<span class=\"review-no\">41 reviews</span>"
                                    + "</div>"
                                    + "<p class=\"product-description\">" + product.Description + "</p>"
                                    + "<p class=\"product-description\">Quantity: " + product.Quantity + "</p>"
                                    + "<h4 class=\"price\">current price: <span>R" + product.Price + "</span></h4>"
                                    + "<p class=\"vote\"><strong>91%</strong> of buyers enjoyed this product! <strong>(87 votes)</strong></p>";
                    prodInfo.InnerHtml = PInfo;
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }
        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditProduct_Click(object sender, EventArgs e)
        {
            string root = System.AppDomain.CurrentDomain.BaseDirectory;
            newImage.PostedFile.SaveAs(root+"/assets/images/ProductImages/" + newImage.Value);
            int intID = int.Parse(Request.QueryString["editProdID"].ToString());
            string newImagePath = "assets/images/ProductImages/" + newImage.Value;
            string strName = newName.Value;
            string strDesc = newDesc.Value;
            int iQuantity = int.Parse(newQuantity.Value.ToString());
            decimal dPrice = decimal.Parse(newPrice.Value.ToString());
            bool isEdited = client.updateProductInfo(intID, strName, strDesc, iQuantity, dPrice, newImagePath);
            if(isEdited)
            {
                errorMessage.Visible = true;
                errorMessage.Attributes.Add("style","color: green");
                errorMessage.InnerText = "Sucessfully Edited product";
                Response.Redirect("AboutProduct.aspx?editProdID=" + intID);
            }else
            {
                errorMessage.Visible = true;
                errorMessage.Attributes.Add("style", "color: red");
                errorMessage.InnerText = "Something went wrong<br>The product was not edited. Try Again";
            }
            
        }
    }
}