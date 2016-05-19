using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using ProjektBlodbank.Data;
using ProjektBlodbank.Business;


namespace ProjektBlodbank.Business
{
    class Start
    {
        public TimeSpan Countdown()
        {
            UserData userdata = new UserData();
            DateTime lastDonation = userdata.GetLastDonationDate();

            DateTime nextDonation = lastDonation.AddMonths(1);
            TimeSpan ts = nextDonation.Subtract(DateTime.Today);
            return ts;
        }



    }
}
