﻿using System;
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
            DataHandler dataHandler = new DataHandler();
            DateTime lastDonation = dataHandler.GetLastDonationDate("Plasma", DataHandler.LoggedInUser);

            DateTime nextDonation = lastDonation.AddMonths(1);
            TimeSpan ts = nextDonation.Subtract(DateTime.Today);

            if (ts <= new TimeSpan(0, 0, 0))
            {
                ts = new TimeSpan(0, 0, 0);
            }

            return ts;
        }
        public TimeSpan CountdownWB()
        {
            DataHandler dataHandler = new DataHandler();
            DateTime lastDonation = dataHandler.GetLastWholeDonationDate("WB", DataHandler.LoggedInUser);

            DateTime nextDonation = lastDonation.AddMonths(3);
            TimeSpan tsWB = nextDonation.Subtract(DateTime.Today);

            if (tsWB <= new TimeSpan(0, 0, 0))
            {
                tsWB = new TimeSpan(0, 0, 0);
            }

            if (Countdown() > tsWB)
            {
                tsWB = Countdown();
            }

            return tsWB;
        }

        public TimeSpan CountdownBloodBus(DateTime pickedDate)
        {
            TimeSpan tsBB = pickedDate.Subtract(DateTime.Today);

            return tsBB;
        }

    }
}
