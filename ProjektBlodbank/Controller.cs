using ProjektBlodbank.Business;
using ProjektBlodbank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank
{
    class Controller
    {
        UserData data = new UserData();
        public string LoggedInUser()
        {
            return UserData.LoggedInUser.Firstname;
        }

        public string LoadStats()
        {
            List<Donation> donationList = data.GetDonations(UserData.LoggedInUser.UserId);
            

            return "";
        }



    }
}
