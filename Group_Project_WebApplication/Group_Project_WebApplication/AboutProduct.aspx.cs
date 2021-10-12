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
            displayReviews();
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
                        string strQunatity = "";
                        if(product.Quantity == 0)
                        {
                            addQuan.Visible = false;
                            btnAddCart.Visible = false;
                            strQunatity = "<h6>Out Of Stock</h6>";
                        }else
                        {
                            strQunatity = product.Quantity.ToString();
                        }
                        string PImage = "<div class=\"preview-pic tab-content\">"
                                            + "<div class=\"tab-pane active\" id=\"pic-1\"><img src=\"" + product.ImageLocation + "\" /></div>"
                                            + "</div>";
                        prodImage.InnerHtml = PImage;
                        prodName.InnerHtml = product.Name;
                        prodDesc.InnerHtml = product.Description;
                        prodAvaliable.InnerHtml = strQunatity;
                        currentPrice.InnerHtml = String.Format("{0:0.00}",product.Price);
                        addQuan.Attributes.Add("max",product.Quantity.ToString());
                        int userID = int.Parse(Session["UserID"].ToString());
                        if (client.reviewExist(userID,productID))
                        {
                            btnAddReview.Text = "Edit Review";
                            btnPostReview.Text = "Post";
                        }
                    }
                }
                else
                {
                    Response.Redirect(Request.UrlReferrer.ToString());
                }
                
            }
        }

        protected void btnAddCart_Click(object sender, EventArgs e)
        {
            int prodID = int.Parse(Request.QueryString["prodID"].ToString());
            int userID = int.Parse(Session["UserID"].ToString());
            int Quantity = int.Parse(addQuan.Value.ToString());
            bool isInCart = false;
            foreach (ShoppingCart c in SalonMaster.cart)
            {
                if (c.prodID.Equals(prodID))
                {
                    isInCart = true;
                    c.Quantity += Quantity;
                    client.editCartQuantity(userID, prodID, c.Quantity);
                }
            }
            if (!isInCart)
            {
                ShoppingCart newItem = new ShoppingCart(prodID, Quantity);
                SalonMaster.cart.Add(newItem);
                client.addToCart(userID, newItem.prodID, newItem.Quantity);
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
                string[] dec = newPrice.Value.ToString().Split('.');
                decimal dPrice = (decimal)(int.Parse(dec[0]) + ((double)int.Parse(dec[1])/100));
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

        private void displayReviews()
        {
            int productID = int.Parse(Request.QueryString["prodID"].ToString());
            var getReviews = client.getReviews(productID);
            string display = "<h3 class=\"title\">Reviews</h3>";
            if(getReviews.Count() > 0)
            {
                foreach (Review r in getReviews)
                {
                    var user = client.getUser(r.userID);
                    string userType = "";
                    if (user.Usertype.Equals("CU"))
                    {
                        userType = "Customer";
                    }else if (user.Usertype.Equals("MA"))
                    {
                        userType = "Manager";
                    }
                    
                    display += "<div class=\"review\">"
                            + "<div class=\"body-review\">"
                            + "<div class=\"name-review\">"+user.Name + " " + user.Surname +"</div>"
                            + "<div class=\"place-review\">"+userType+"</div>"
                            + "<div class=\"desc-review\">"+r.userReview+"</div>"
                            + "</div>"
                            + "</div>";
                }
                prodReviews.InnerHtml = display;
            }
            else
            {
                display += "<h6>There are currently no Reviews be the first to review the product</h6>";
                prodReviews.InnerHtml = display;
            }
            
        }

        protected void btnPostReview_Click(object sender, EventArgs e)
        {
            if(Session["UserID"] != null)
            {
                int prodID = int.Parse(Request.QueryString["prodID"].ToString());
                int userID = int.Parse(Session["UserID"].ToString());
                string review = userReview.Value;
                bool doesReviewExist = client.reviewExist(userID, prodID);
                if(doesReviewExist)
                {
                    client.updateReview(userID, prodID, review);
                }else
                {
                    client.addReview(userID, prodID, review);
                }
                Response.Redirect("AboutProduct.aspx?prodID=" + prodID);
            }
        }

        protected void btnAddReview_Click(object sender, EventArgs e)
        {
            if(Session["UserType"] != null)
            {
                addRating.Visible = true;
                btnAddReview.Visible = false;
            }
        }
    }
}