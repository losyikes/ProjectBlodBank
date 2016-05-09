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
            bool matchingPasswords;
            if (password1 == password2)
                matchingPasswords = true;
            else
                matchingPasswords = false;
            return matchingPasswords;
        }
    }
}
