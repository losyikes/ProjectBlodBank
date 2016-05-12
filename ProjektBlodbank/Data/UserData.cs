using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ProjektBlodbank.Business;

namespace ProjektBlodbank.Data
{
    class UserData
    {
        private BloodbankData db;

        public UserData()
        {
            //db = new DataContext("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
            db = new BloodbankData();
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

        public Totals GetTotals(int userID)
        {
            var totals = from x in db.Totals
                         where x.UserId == userID
                         select x;
            return (Totals)totals;
        }

    }
}
