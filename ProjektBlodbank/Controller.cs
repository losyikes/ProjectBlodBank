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

        public Statistics CreateStats()
        {
            List<Donation> donationList = data.GetDonations(UserData.LoggedInUser.UserId);
            Statistics stats = new Statistics();

            stats.memberDurationStat = (DateTime.Now).Subtract(UserData.LoggedInUser.RegisteredDate);

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

        

    }
}
