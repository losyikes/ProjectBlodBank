using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using ProjektBlodbank.Business;

namespace ProjektBlodbank.Data
{
    class DataHandler
    {
        private BloodbankDataContext db;

        public static User LoggedInUser { get; set; }
        public DataHandler()
        {
            db = new BloodbankDataContext();
        }
        public DateTime GetLastDonationDate(string type, User user)
        {
            var donation = (from x in db.Donation
                        where x.UserId == user.UserId
                        orderby x.DonationDate descending
                        select x).FirstOrDefault();

            DateTime date;

            if (donation == null)
            {
                date = DateTime.Now.AddDays(-30);
            }
            else
            {
                date = donation.DonationDate;
            }

            return date;
        }

        public DateTime GetLastWholeDonationDate(string type, User user)
        {
            var donation = (from x in db.Donation
                        where x.UserId == user.UserId
                        where x.DonationType == "WholeBlood"
                        orderby x.DonationDate descending
                        select x).FirstOrDefault();

            DateTime date;

            if (donation == null)
            {
                date = DateTime.Now.AddDays(-30);
            }
            else
            {
                date = donation.DonationDate;
            }

            return date;
        }

        public void AddUser(User user)
        {
            db.User.InsertOnSubmit(user);
            db.SubmitChanges();
        }

        public void AddDonation(Donation donation)
        {
            db.Donation.InsertOnSubmit(donation);
            db.SubmitChanges();
        }

        public User GetUser(string username)
        {
            var user = (from x in db.User
                        where x.Login == username
                        select x).SingleOrDefault();
            return user;
        }

        public List<Donation> GetDonations(int userID)
        {
            List<Donation> donationList = new List<Donation>(); 
            var donation = from x in db.Donation
                           where x.UserId == userID
                           select x;
            donationList = donation.ToList();

            return donationList;
        }

        public List<string> GetBloodBusStops()
        {
            List<string> busStopList = new List<string>();
            var busStop = (from x in db.BloodBus
                          select x.Location).Distinct();
            busStopList = busStop.ToList();

            busStopList.Sort();

            return busStopList;
        }

        public List<DateTime> GetBloodBusDates(string location)
        {
            List<DateTime> dateList = new List<DateTime>();
            var dates = from x in db.BloodBus
                        where x.Location == location
                        where x.Date >= DateTime.Now.Date
                        select x.Date;
            dateList = dates.ToList();

            return dateList;
        }

        public Totals GetTotals(int userID)
        {
            var totals = from x in db.Totals
                         where x.UserId == userID
                         select x;
            return (Totals)totals;
        }
    }
}
