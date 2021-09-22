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
        bool updateProductInfo(int prodID,string prodName,string prodDesc,int prodQuantity,decimal prodPrice,string imgLoc);
    }
}
