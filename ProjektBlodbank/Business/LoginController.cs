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
            if (inputPassword == user.Password)
            {
                UserData.LoggedInUser = user;
                return true;
            }
            else
                return false;
        }
    }
}
