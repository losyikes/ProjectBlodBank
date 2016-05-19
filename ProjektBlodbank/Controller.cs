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
            Statistics stat = new Statistics();
            //    public TimeSpan memberDurationStat { get; set; }
            //public int TotalDonationStat { get; set; }
            //public int TotDonWholeStat { get; set; }
            //public int TotDonPlasmaStat { get; set; }
            //public int AmountDonatedStat { get; set; }
            //public int AmDonWholeStat { get; set; }
            //public int AmDonPlasmaStat { get; set; }
            //public int TotalTimeDonatedStat { get; set; }
            //public int TotTimeWholeStat { get; set; }
            //public int TotTimePlasmaStat { get; set; }

            stat.memberDurationStat = (DateTime.Now).Subtract(donationList[0].RegisteredDate);

            for (int i = 0; i < donationList.Count; i++)
            {

            }

            return "";
        }

        

    }
}
