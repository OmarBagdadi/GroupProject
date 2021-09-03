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
            User newUser;
            if(phoneNo != "")
            {
                newUser = new User
                {
                    Name = uName,
                    Surname = Surname,
                    Email = Email,
                    Usertype = Usertype,
                    PhoneNo = phoneNo
                };
            }else
            {
                newUser = new User
                {
                    Name = uName,
                    Surname = Surname,
                    Email = Email,
                    Usertype = Usertype
                };
            }
            
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
    }
}
