using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Group_Project_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISalonService" in both code and config file together.
    [ServiceContract]
    public interface ISalonService
    {
        [OperationContract]
        bool Register(string Name,string Surname,string Email, string Password,string phoneNo, string Usertype);

        [OperationContract]
        bool doesExist(string Name, string Surname, string Email);

        [OperationContract]
        bool UpdateInfo(int id, string name, string Surname, string email, string phoneNo,string UserType);

        [OperationContract]
        bool registerStaff(string name, string Surname, string email, string UserType);

        [OperationContract]
        User SignIn(string Email,string Password);

        [OperationContract]
        User getUser(int userID);

        [OperationContract]
        List<Product> getLatestProducts();

        [OperationContract]
        List<Product> getHairApp();

        [OperationContract]
        List<Product> getHairProd();

        [OperationContract]
        List<Product> getHairAcc();

        [OperationContract]
        List<Product> getProducts();

        [OperationContract]
        Product getProduct(int prodID);

        [OperationContract]
        void updateProductQuantity(int prodID, int subtractQunatity);

        [OperationContract]
        bool updateProductInfo(int prodID,string prodName,string prodDesc,int prodQuantity,string prodCat,decimal prodPrice,string imgLoc);

        [OperationContract]
        bool removeProduct(int prodID);

        [OperationContract]
        bool addProduct(string prodName, string prodDesc, decimal prodPrice, string imgLoc, int prodQuantity, string Category);

        [OperationContract]
        void addToCart(int userID,int prodID,int Quantity);

        [OperationContract]
        bool isInCart(int userID, int prodID);

        [OperationContract]
        List<Cart> getCartItems(int userID);

        [OperationContract]
        void removeFromCart(int userID,int prodID);

        [OperationContract]
        void editCartQuantity(int userID,int prodID,int Quantity);

        [OperationContract]
        void clearCart(int userID);

        [OperationContract]
        int addInvoice(int userID,string Products,double Subtotal, double VAT, double Discount, double Shipping, double GrandTotal);

        [OperationContract]
        Invoice getInvoice(int invoiceID);

        [OperationContract]
        List<Invoice> getUserInvoice(int userID);

        [OperationContract]
        bool doesInvoiceExist(int userID);

        [OperationContract]
        int updateUnpaidInvoice(int userID, string Products, double Subtotal, double VAT, double Discount, double Shipping, double GrandTotal);

        [OperationContract]
        void paidInvoice(int invoiceID, string Address);

        [OperationContract]
        void updateProductReport(int totalHASold, int totalHPSold, int totalHAPSold);

        [OperationContract]
        ProductReport getProductReport();

        [OperationContract]
        void addReview(int userID,int productID, string review);

        [OperationContract]
        bool reviewExist(int userID, int productID);

        [OperationContract]
        void updateReview(int userID, int productID, string review);

        [OperationContract]
        int getNumReviews(int productID);

        [OperationContract]
        List<Review> getReviews(int productID);
    }
}
