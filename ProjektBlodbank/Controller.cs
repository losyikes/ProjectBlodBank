using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank
{
    class Controller
    {
        public string LoggedInUser()
        {
            return Data.UserData.LoggedInUser.Firstname;
        }


    }
}
