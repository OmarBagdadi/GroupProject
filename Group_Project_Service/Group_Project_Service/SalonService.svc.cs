using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Group_Project_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SalonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SalonService.svc or SalonService.svc.cs at the Solution Explorer and start debugging.
    public class SalonService : ISalonService
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public bool Register(string uName, string Surname, string Email, string Password, string phoneNo, string Usertype)
        {
            bool registered = false;
            User newUser = new User
            {
                Name = uName,
                Surname = Surname,
                Email = Email,
                Password = Password,
                Usertype = Usertype,
                PhoneNo = phoneNo
            };
            
            db.Users.InsertOnSubmit(newUser);
            try
            {
                db.SubmitChanges();
                registered = true;
            }catch(Exception ex)
            {
                ex.GetBaseException();
                registered = false;
            }
            return registered;
        }

        public bool UpdateInfo(int id, string name, string Surname, string email, string phoneNo, string UserType)
        {
            bool updated = false;
            var updateUser = (from u in db.Users
                              where u.Id.Equals(id)
                              select u).FirstOrDefault();


            updateUser.Name = name;
            updateUser.Surname = Surname;
            updateUser.Email = email;
            updateUser.PhoneNo = phoneNo;

            try
            {
                db.SubmitChanges();
                updated = true;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
                updated = false;
            }

            return updated;
        }

        public User SignIn(string Email, string Password)
        {
            var user = (from u in db.Users
                        where u.Email.Equals(Email) && u.Password.Equals(Password)
                        select u).FirstOrDefault();
            return user;
        }

        public bool doesExist(string Name, string Surname, string Email)
        {
            Boolean exists = false;

            var user = (from u in db.Users
                        where u.Name.Equals(Name) && u.Surname.Equals(Surname)
                        && u.Email.Equals(Email)
                        select u).FirstOrDefault();

            if(user is User)
            {
                exists = true;
            }else
            {
                exists = false;
            }

            return exists;
        }

        public bool registerStaff(string name, string Surname, string email, string UserType)
        {
            bool isStaff = false;
            var reqUser = (from u in db.Users
                           where u.Name.Equals(name) && u.Surname.Equals(Surname)
                           && u.Email.Equals(email)
                           select u).FirstOrDefault();
            if(reqUser is User)
            {
                isStaff = true;
                reqUser.Usertype = "MA";
            }else
            {
                isStaff = false;
            }

            try
            {
                db.SubmitChanges();
            }catch(Exception ex)
            {
                ex.GetBaseException();
            }
            return isStaff;
        }

        public List<Product> getLatestProducts()
        {
            List<Product> latestProducts = new List<Product>();
            var lProd = (from p in db.Products
                         where p.LatestProduct.Equals(1)
                         select p);

            foreach(Product p in lProd)
            {
                latestProducts.Add(p);
            }

            return latestProducts;
        }

        public List<Product> getProducts()
        {
            List<Product> products = new List<Product>();
            List<Product> prod = (from p in db.Products
                                  select p).ToList<Product>();
            //Arranging the products from newest to oldest
            for(int i = (prod.Count() - 1); i >-1;i--)
            {
                products.Add(prod.ElementAt(i));
            }
            return products;
        }

        public Product getProduct(int prodID)
        {
            Product prod = null;
            var reqProd = (from p in db.Products
                           where p.Id.Equals(prodID)
                           select p).FirstOrDefault();

            if(reqProd is Product)
            {
                prod = reqProd;
            }

            return prod;
        }

        public void updateProductQuantity(int prodID, int subtractQunatity)
        {
            var reqProd = (from p in db.Products
                           where p.Id.Equals(prodID)
                           select p).FirstOrDefault();
            reqProd.Quantity -= subtractQunatity;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public bool updateProductInfo(int prodID, string prodName, string prodDesc, int prodQuantity, string prodCat, decimal prodPrice, string imgLoc)
        {
            bool didUpdate = false;
            Product reqProduct = (from p in db.Products
                              where p.Id.Equals(prodID)
                              select p).FirstOrDefault();
            reqProduct.Name = prodName;
            reqProduct.Description = prodDesc;
            reqProduct.Quantity = prodQuantity;
            reqProduct.Price = prodPrice;
            reqProduct.Category = prodCat;
            if(!imgLoc.Equals(""))
            {
                reqProduct.ImageLocation = imgLoc;
            }
            try
            {
                db.SubmitChanges();
                didUpdate = true;
            }
            catch (Exception ex)
            {
                didUpdate = false;
                ex.GetBaseException();
            }
            return didUpdate;
        }

        public List<Product> getHairApp()
        {
            List<Product> products = new List<Product>();
            var prod = (from p in db.Products
                        where p.Category.Equals("HAP")
                        select p);

            foreach (Product p in prod)
            {
                products.Add(p);
            }

            return products;
        }

        public List<Product> getHairProd()
        {
            List<Product> products = new List<Product>();
            var prod = (from p in db.Products
                        where p.Category.Equals("HP")
                        select p);

            foreach (Product p in prod)
            {
                products.Add(p);
            }

            return products;
        }

        public List<Product> getHairAcc()
        {
            List<Product> products = new List<Product>();
            var prod = (from p in db.Products
                        where p.Category.Equals("HA")
                        select p);

            foreach (Product p in prod)
            {
                products.Add(p);
            }

            return products;
        }

        public bool removeProduct(int prodID)
        {
            bool isRemoved = false;
            Product removeItem = (from c in db.Products
                               where c.Id.Equals(prodID)
                               select c).FirstOrDefault();
            db.Products.DeleteOnSubmit(removeItem);
            try
            {
                db.SubmitChanges();
                isRemoved = true;
            }
            catch (Exception ex)
            {
                isRemoved = false;
                ex.GetBaseException();
            }
            return isRemoved;
        }

        public bool addProduct(string prodName, string prodDesc, decimal prodPrice, string imgLoc, int prodQuantity, string Category)
        {
            bool isAdded = false;
            Product newProduct = new Product
            {
                Name = prodName,
                Description = prodDesc,
                Price = prodPrice,
                ImageLocation = imgLoc,
                Quantity = prodQuantity,
                Category = Category,
                LatestProduct = 1
            };
            db.Products.InsertOnSubmit(newProduct);
            try
            {
                db.SubmitChanges();
                isAdded = true;
            }
            catch (Exception ex)
            {
                isAdded = false;
                ex.GetBaseException();
            }
            return isAdded;
        }

        public void addToCart(int userID, int prodID, int Quantity)
        {
            Cart newItem = new Cart
            {
                userID = userID,
                productID = prodID,
                Quantity = Quantity
            };
            db.Carts.InsertOnSubmit(newItem);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public List<Cart> getCartItems(int userID)
        {
            List<Cart> cartItems = new List<Cart>();
            var userCart = (from c in db.Carts
                            where c.userID.Equals(userID)
                            select c);
            foreach (Cart c in userCart)
            {
                cartItems.Add(c);
            }

            return cartItems;
        }

        public void removeFromCart(int userID,int prodID)
        {
            Cart removeItem = (from c in db.Carts
                               where c.productID.Equals(prodID) && c.productID.Equals(prodID)
                               select c).FirstOrDefault();
            db.Carts.DeleteOnSubmit(removeItem);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public void editCartQuantity(int userID, int prodID, int Quantity)
        {
            var cartItem = (from c in db.Carts
                            where c.userID.Equals(userID) && c.productID.Equals(prodID)
                            select c).FirstOrDefault();
            cartItem.Quantity = Quantity;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public void clearCart(int userID)
        {
            List<Cart> deleteItems = new List<Cart>();
            var userItem = (from c in db.Carts
                            where c.userID.Equals(userID)
                            select c);
            foreach(Cart c in userItem)
            {
                deleteItems.Add(c);
            }
            db.Carts.DeleteAllOnSubmit(deleteItems);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public bool isInCart(int userID, int prodID)
        {
            bool isInCart = false;
            var checkProd = (from c in db.Carts
                             where c.userID.Equals(userID) && c.productID.Equals(prodID)
                             select c).FirstOrDefault();
            if(checkProd is Cart)
            {
                isInCart = true;
            }else
            {
                isInCart = false;
            }
            return isInCart;
        }

        public int addInvoice(int userID, string Products, double Subtotal, double VAT, double Discount, double Shipping, double GrandTotal)
        {
            int invoiceID = -1;
            Invoice newInvoice = new Invoice
            {
                userID = userID,
                Products = Products,
                Subtotal = (decimal)Subtotal,
                VAT = (decimal)VAT,
                Discount = (decimal)Discount,
                ShippingFee = (decimal)Shipping,
                GrandTotal = (decimal)GrandTotal
            };
            db.Invoices.InsertOnSubmit(newInvoice);
            try
            {
                db.SubmitChanges();
                invoiceID = newInvoice.Id;
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
            return invoiceID;
        }

        public Invoice getInvoice(int invoiceID)
        {
            Invoice reqInvoice = null;
            var getInvoice = (from i in db.Invoices
                              where i.Id.Equals(invoiceID)
                              select i).FirstOrDefault();
            if(getInvoice is Invoice)
            {
                reqInvoice = getInvoice;
            }
            return reqInvoice;
        }

        public void paidInvoice(int invoiceID, string Address)
        {
            var reqInvoice = (from i in db.Invoices
                              where i.Id.Equals(invoiceID)
                              select i).FirstOrDefault();
            reqInvoice.isPaid = 1;
            reqInvoice.Date = DateTime.Now.Date;
            reqInvoice.Address = Address;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public bool doesInvoiceExist(int userID)
        {
            bool doesExist = false;
            var userInvoice = (from i in db.Invoices
                               where i.userID.Equals(userID) && !(i.isPaid.Equals(1))
                               select i).FirstOrDefault();
            if(userInvoice is Invoice)
            {
                doesExist = true;
            }else
            {
                doesExist = false;
            }
            return doesExist;
        }

        public int updateUnpaidInvoice(int userID, string Products, double Subtotal, double VAT, double Discount, double Shipping, double GrandTotal)
        {
            int invoiceID = 0;
            var userInvoice = (from i in db.Invoices
                               where i.userID.Equals(userID) && i.isPaid.Equals(null)
                               select i).FirstOrDefault();
            userInvoice.Products = Products;
            userInvoice.Subtotal= (decimal)Subtotal;
            userInvoice.VAT= (decimal)VAT;
            userInvoice.Discount= (decimal)Discount;
            userInvoice.ShippingFee = (decimal)Shipping;
            userInvoice.GrandTotal = (decimal)GrandTotal;
            invoiceID = userInvoice.Id;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
            return invoiceID;
        }

        public List<Invoice> getUserInvoice(int userID)
        {
            List<Invoice> userInvoices = new List<Invoice>();
            var reqInvoices = (from i in db.Invoices
                               where i.userID.Equals(userID)
                               select i);
            foreach(Invoice i in reqInvoices)
            {
                userInvoices.Add(i);
            }
            return userInvoices;
        }

        public void updateProductReport(int totalHASold, int totalHPSold, int totalHAPSold)
        {
            var getReport = (from r in db.ProductReports
                             select r).FirstOrDefault();
            var HA = getHairAcc();
            var HP = getHairProd();
            var HAP = getHairApp();
            var AP = getProducts();
            foreach(Product p in HA)
            {
                getReport.totalHA += p.Quantity;
            }
            foreach (Product p in HP)
            {
                getReport.totalHP += p.Quantity;
            }
            foreach (Product p in HAP)
            {
                getReport.totalHAP += p.Quantity;
            }
            foreach (Product p in AP)
            {
                getReport.TotalProdsAvaliable += p.Quantity;
            }
            getReport.totalHASold += totalHASold;
            getReport.totalHPSold += totalHPSold;
            getReport.totalHAPSold += totalHAPSold;
            getReport.TotalProdsSold = totalHAPSold + totalHASold + totalHPSold;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public ProductReport getProductReport()
        {
            ProductReport prodRep = (from r in db.ProductReports
                                     select r).FirstOrDefault();
            return prodRep;
        }

        public void addReview(int userID, int productID, string review)
        {
            Review newReview = new Review
            {
                userID = userID,
                prodID = productID,
                userReview = review,
                dateReviewed = DateTime.Now
            };
            db.Reviews.InsertOnSubmit(newReview);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public int getNumReviews(int productID)
        {
            int numReviews = (from r in db.Reviews
                              where r.prodID.Equals(productID)
                              select r).Count();
            return numReviews;
        }

        public List<Review> getReviews(int productID)
        {
            List<Review> productReviews = new List<Review>();
            var reqReviews = (from r in db.Reviews
                              where r.prodID.Equals(productID)
                              select r);

            foreach(Review r in reqReviews)
            {
                productReviews.Add(r);
            }

            return productReviews;
        }

        public void updateReview(int userID, int productID, string review)
        {
            var updateRev = (from r in db.Reviews
                             where r.userID.Equals(userID) && r.prodID.Equals(productID)
                             select r).FirstOrDefault();
            updateRev.userReview = review;
            updateRev.dateReviewed = DateTime.Now;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
        }

        public bool reviewExist(int userID, int productID)
        {
            bool doesExist = false;
            var checkReview = (from r in db.Reviews
                             where r.userID.Equals(userID) && r.prodID.Equals(productID)
                             select r).FirstOrDefault();
            if(checkReview != null)
            {
                doesExist = true;
            }
            else
            {
                doesExist = false;
            }
            return doesExist;
        }

        public User getUser(int userID)
        {
            User reqUser = (from u in db.Users
                            where u.Id.Equals(userID)
                            select u).FirstOrDefault();

            return reqUser;
        }
    }
}
