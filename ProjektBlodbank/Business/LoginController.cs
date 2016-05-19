using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektBlodbank.Data;
using ProjektBlodbank.Business;

namespace ProjektBlodbank
{
    class LoginController
    {
        public bool ValidatePassword(string password1, string password2)
        {
            if (password1 == password2)
                return true;
            else
                return false;
        }

        internal bool Login(string inputUsername, string inputPassword)
        {
            UserData userData = new UserData();
            User user = userData.GetUser(inputUsername);
            try
            {
                if (inputPassword == user.Password)
                {
                    UserData.LoggedInUser = user;
                    return true;
                }
                else
                    return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }

        internal bool CreateNewUser(string firstName, string lastName, string streetName, string city, string zipCode,
            string cPRNumber, string username, string password, string bloodtype, string email, string phoneNumber)
        {
            int intZipCode;
            bool resultZipCode = int.TryParse(zipCode, out intZipCode);
            int intCPRNumber;
            bool resultCPRNumber = int.TryParse(cPRNumber, out intCPRNumber);
            int intPhoneNumber;
            bool resultPhoneNumber = int.TryParse(phoneNumber, out intPhoneNumber);
            if (resultZipCode == false || resultCPRNumber == false || resultPhoneNumber == false)
                return false;
            else
            {
                User newUser = new User(firstName, lastName, streetName, city, intZipCode,
                    intCPRNumber, username, password, bloodtype, email, intPhoneNumber);
                UserData userdata = new UserData();
                userdata.AddUser(newUser);
                return true;
            }
        }
    }
}
