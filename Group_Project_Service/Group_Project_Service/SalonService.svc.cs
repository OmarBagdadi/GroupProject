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
            var prod = (from p in db.Products
                         select p);

            foreach (Product p in prod)
            {
                products.Add(p);
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

        public bool updateProductInfo(int prodID, string prodName, string prodDesc, int prodQuantity, decimal prodPrice, string imgLoc)
        {
            bool didUpdate = false;
            var reqProduct = (from p in db.Products
                              where p.Id.Equals(prodID)
                              select p).FirstOrDefault();
            reqProduct.Name = prodName;
            reqProduct.Description = prodDesc;
            reqProduct.Quantity = prodQuantity;
            reqProduct.Price = prodPrice;
            reqProduct.ImageLocation = imgLoc;

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
    }
}
