using Group_Project_WebApplication.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group_Project_WebApplication
{
    public partial class Logout : System.Web.UI.Page
    {
        SalonServiceClient client = new SalonServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserType"] != null)
            {
                int userID = int.Parse(Session["UserID"].ToString());
                if(SalonMaster.cart.Count > 0)
                {
                    foreach (ShoppingCart s in SalonMaster.cart)
                    {
                        bool isInCart = client.isInCart(userID, s.prodID);
                        if(isInCart)
                        {
                            client.editCartQuantity(userID, s.prodID, s.Quantity);
                        }else
                        {
                            client.addToCart(userID, s.prodID, s.Quantity);
                        }
                    }
                }
                SalonMaster.cart.Clear();
                Session["UserType"] = null;
                Session["UserID"] = null;
                Session["UserEmail"] = null;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}