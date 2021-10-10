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
            
            if (Request.QueryString["editProdID"] != null)
            {
                btnAddProduct.Visible = false;
                if(!IsPostBack)
                {
                    btnAddCart.Visible = false;
                    hideQuantity.Visible = false;
                    int productID = int.Parse(Request.QueryString["editProdID"].ToString());
                    var editP = client.getProduct(productID);
                    addCategory.Visible = true;
                    newImage.Visible = true;
                    newName.Visible = true;
                    newDesc.Visible = true;
                    newQuantity.Visible = true;
                    newPrice.Visible = true;
                    addCategory.Value = editP.Category;
                    addCategory.Items.FindByValue(editP.Category).Selected = true;
                    oldImage.Src = editP.ImageLocation;
                    newName.Value = editP.Name;
                    newDesc.Value = editP.Description;
                    newQuantity.Value = editP.Quantity.ToString();
                    newPrice.Value = String.Format("{0:0.00}", editP.Price);
                }
            }else if(Request.QueryString["addProd"] != null)
            {
                btnEditProduct.Visible = false;
                btnAddProduct.Visible = true;
                addCategory.Visible = true;
                prodReviews.Visible = false;
                addRating.Visible = false;
                oldImage.Src = "assets/images/edit-icon.png";
                btnAddCart.Visible = false;
                hideQuantity.Visible = false;
                newImage.Visible = true;
                newName.Visible = true;
                newDesc.Visible = true;
                newQuantity.Visible = true;
                newPrice.Visible = true;
            }
            else
            {
                btnAddProduct.Visible = false;
                if (Request.QueryString["prodID"] != null)
                {
                    if(!IsPostBack)
                    {
                        if (Session["UserType"] != null)
                        {
                            addQuan.Visible = true;
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
                        else
                        {
                            hideQuantity.Visible = false;
                            btnAddCart.Visible = false;
                            btnEditProduct.Visible = false;
                        }
                        int productID = int.Parse(Request.QueryString["prodID"].ToString());
                        var product = client.getProduct(productID);
                        string PImage = "<div class=\"preview-pic tab-content\">"
                                            + "<div class=\"tab-pane active\" id=\"pic-1\"><img src=\"" + product.ImageLocation + "\" /></div>"
                                            + "</div>";
                        prodImage.InnerHtml = PImage;
                        prodName.InnerHtml = product.Name;
                        prodDesc.InnerHtml = product.Description;
                        prodAvaliable.InnerHtml = product.Quantity.ToString();
                        currentPrice.InnerHtml = String.Format("{0:0.00}",product.Price);
                        addQuan.Attributes.Add("max",product.Quantity.ToString());
                    }
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
                
            }
        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {
            int prodID = int.Parse(Request.QueryString["prodID"].ToString());
            int Quantity = int.Parse(addQuan.Value.ToString());
            bool isInCart = false;
            foreach (ShoppingCart c in SalonMaster.cart)
            {
                if (c.prodID.Equals(prodID))
                {
                    isInCart = true;
                    c.Quantity += Quantity;
                }
            }
            if (!isInCart)
            {
                ShoppingCart newItem = new ShoppingCart(prodID, Quantity);
                SalonMaster.cart.Add(newItem);
            }
            Response.Redirect("AboutProduct.aspx?prodID=" + prodID);

        }

        protected void btnEditProduct_Click(object sender, EventArgs e)
        {
            if(Request.QueryString["editProdID"] != null)
            {
                string root = System.AppDomain.CurrentDomain.BaseDirectory;
                string newImagePath = "";
                if (!newImage.PostedFile.FileName.Equals(""))
                {
                    newImage.PostedFile.SaveAs(root + "/assets/images/ProductImages/" + newImage.Value);
                    newImagePath = "assets/images/ProductImages/" + newImage.Value;
                }
                int intID = int.Parse(Request.QueryString["editProdID"].ToString());
                string strName = newName.Value;
                string strDesc = newDesc.Value;
                string strCat = addCategory.Value;
                int iQuantity = int.Parse(newQuantity.Value.ToString());
                decimal dPrice = decimal.Parse(newPrice.Value); 
                bool isEdited = client.updateProductInfo(intID, strName, strDesc, iQuantity, strCat,dPrice, newImagePath);
                if (isEdited)
                {
                    userMessage.Visible = true;
                    userMessage.Attributes.Add("style", "color: green");
                    userMessage.InnerText = "Sucessfully Edited product";
                    Response.Redirect("AboutProduct.aspx?editProdID=" + intID);
                }
                else
                {
                    userMessage.Visible = true;
                    userMessage.Attributes.Add("style", "color: red");
                    userMessage.InnerText = "Something went wrong<br>The product was not edited. Try Again";
                }
            }else
            {
                int prodID = int.Parse(Request.QueryString["prodID"].ToString());
                Response.Redirect("AboutProduct.aspx?editProdID="+prodID);
            }
        }

        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            string root = System.AppDomain.CurrentDomain.BaseDirectory;
            string newImagePath = "assets/images/edit-icon.png";
            if (!newImage.PostedFile.FileName.Equals(""))
            {
                newImage.PostedFile.SaveAs(root + "/assets/images/ProductImages/" + newImage.Value);
                newImagePath = "assets/images/ProductImages/" + newImage.Value;
            }
            string prodName = newName.Value;
            string prodDesc = newDesc.Value;
            int prodQuantity = int.Parse(newQuantity.Value);
            decimal prodPrice = decimal.Parse(newPrice.Value);
            string prodCategory = addCategory.Value;
            bool isAdded = client.addProduct(prodName, prodDesc, prodPrice, newImagePath, prodQuantity, prodCategory);
            if(isAdded)
            {
                userMessage.Visible = true;
                userMessage.Attributes.Add("style", "color: green");
                userMessage.InnerText = "Sucessfully Added product";
            }
            else
            {
                userMessage.Visible = true;
                userMessage.Attributes.Add("style", "color: red");
                userMessage.InnerText = "Something went wrong<br>The product was not edited. Try Again";
            }
        }
    }
}