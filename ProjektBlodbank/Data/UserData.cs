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
    class UserData
    {
        private BloodbankDataContext db;

        public static User LoggedInUser { get; set; }
        public UserData()
        {
            //db = new DataContext("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            db = new BloodbankDataContext();
            
        }
        public DateTime GetLastDonationDate(string type, User user)
        {
            var valg = (from x in db.Donation
                        where x.UserId == user.UserId
                        orderby x.DonationDate descending
                        select x).FirstOrDefault();


                        //group x by x.DonationDate into grp
                        //select grp.OrderByDescending(g => g.DonationDate)).FirstOrDefault();

            Donation valg2 = valg;

            DateTime date = valg2.DonationDate;
            
            
            
            //DateTime date = new DateTime(2016, 5, 15);

            return date;
        }

        public DateTime GetLastWholeDonationDate(string type, User user)
        {
            var valg = (from x in db.Donation
                        where x.UserId == user.UserId
                        where x.DonationType == "WholeBlood"
                        orderby x.DonationDate descending
                        select x).FirstOrDefault();

            Donation valg2 = valg;

            DateTime date = valg2.DonationDate;

            return date;
        }


        public TimeSpan Countdown(DateTime date)
        {
            DateTime nextDonation = date.AddMonths(1);
            TimeSpan ts = nextDonation.Subtract(DateTime.Today);
            return ts;
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

        public void AddTotals(Totals totals)
        {
            db.Totals.InsertOnSubmit(totals);
            db.SubmitChanges();
        }

        public User GetUser(int userID)
        {
            var user = from x in db.User
                       where x.UserId == userID
                       select x;
            return (User)user;
        }

        public User GetUser(string username)
        {
            var user = (from x in db.User
                        where x.Login == username
                        select x).SingleOrDefault();
            return (User)user;
        }

        public string GetFirstName(int userID)
        {
            User user = GetUser(userID);
            return user.Firstname;
        }
        public Donation GetDonation(int userID)
        {
            var donation = from x in db.Donation
                           where x.UserId == userID
                           select x;
            return (Donation)donation;
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

        //var empnamesEnum = from emp in emplist
        //                   select emp.Ename;
        //List<string> empnames = empnamesEnum.ToList();

        
        public Totals GetTotals(int userID)
        {
            var totals = from x in db.Totals
                         where x.UserId == userID
                         select x;
            return (Totals)totals;
        }

    }
    
}
