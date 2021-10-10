using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group_Project_WebApplication
{
    public class ShoppingCart
    {
        public int prodID;
        public int Quantity;
        public ShoppingCart(int prodID,int Quantity)
        {
            this.prodID = prodID;
            this.Quantity = Quantity;
        }
    }
}