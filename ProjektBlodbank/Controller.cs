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
        DataHandler data = new DataHandler();
        public string LoggedInUser()
        {
            return DataHandler.LoggedInUser.Firstname;
        }

        public Statistics CreateStats()
        {
            List<Donation> donationList = data.GetDonations(DataHandler.LoggedInUser.UserId);
            Statistics stats = new Statistics();

            stats.memberDurationStat = (DateTime.Now).Subtract(DataHandler.LoggedInUser.RegisteredDate);

            for (int i = 0; i < donationList.Count; i++)
            {
                stats.TotalDonationStat++;
                stats.AmountDonatedStat += donationList[i].Amount;
                stats.TotalTimeDonatedStat += donationList[i].Duration;


                if (donationList[i].DonationType == "WholeBlood")
                {
                    stats.TotDonWholeStat++;
                    stats.AmDonWholeStat += donationList[i].Amount;
                    stats.TotTimeWholeStat += donationList[i].Duration;
                }
                else if (donationList[i].DonationType == "Plasma")
                {
                    stats.TotDonPlasmaStat++;
                    stats.AmDonPlasmaStat += donationList[i].Amount;
                    stats.TotTimePlasmaStat += donationList[i].Duration;
                }
            }

            return stats;
        }

        public List<string> GetBusStops()
        {
            List<string> busStops = data.GetBloodBusStops();

            return busStops;
        }

        public List<string> GetBusTimes()
        {
            List<DateTime> busTimes = data.GetBloodBusDates(DataHandler.LoggedInUser.PreferredBusLocation);
            List<string> stringTimes = new List<string>();

            for (int i = 0; i < busTimes.Count; i++)
            {
                stringTimes.Add(busTimes[i].Date.ToString("dd/MM/yyyy"));
            }
            return stringTimes;
        }

    }
}
