using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using ProjektBlodbank.Controller;

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

        public User GetUser(int userID)
        {
            var user = from x in db.User
                     where x.UserId == userID
                     select x;
            return (User)user;
        }

        public void AddUser(User user)
        {
                db.User.InsertOnSubmit(user);
                db.SubmitChanges();
        }

        public string GetFirstName(int userID)
        {
            User user = GetUser(userID);
            return user.Firstname;
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
