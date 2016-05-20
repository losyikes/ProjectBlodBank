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
        TimeSpan ts;
        public TimeSpan Countdown()
        {
            UserData userdata = new UserData();
            DateTime lastDonation = userdata.GetLastDonationDate("Plasma", UserData.LoggedInUser);

            DateTime nextDonation = lastDonation.AddMonths(1);
            ts = nextDonation.Subtract(DateTime.Today);

            if (ts <= new TimeSpan(0, 0, 0))
            {
                ts = new TimeSpan(0, 0, 0);
            }

            return ts;
        }
        public TimeSpan CountdownWB()
        {
            UserData userdata = new UserData();
            DateTime lastDonation = userdata.GetLastWholeDonationDate("WB", UserData.LoggedInUser);

            DateTime nextDonation = lastDonation.AddMonths(3);
            TimeSpan tsWB = nextDonation.Subtract(DateTime.Today);

            if (tsWB <= new TimeSpan(0, 0, 0))
            {
                tsWB = new TimeSpan(0, 0, 0);
            }

            if (tsWB <= ts)
            {
                tsWB = ts;
            }

            return tsWB;
        }



    }
}
