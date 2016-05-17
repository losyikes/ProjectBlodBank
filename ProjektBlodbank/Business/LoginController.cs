using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return true;
        }
    }
}
