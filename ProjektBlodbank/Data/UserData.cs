using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace ProjektBlodbank.Data
{
    class UserData
    {
        private DataContext db;

        public UserData()
        {
            db = new DataContext("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");
        }

        public User GetUser(int userID)
        {
            var user = from x in db.GetTable<User>()
                     where x.userID == userID
                     select x;
            return user;
        }

        public void AddUser(User user)
        {
                //db.User.InsertOnSubmit(user); I'm not sure if this is correct
                db.User.Add(user); // or if this is
                db.SubmitChanges();
        }

        public string GetFirstName(int userID)
        {

            User user = GetUser();
            return user.FirstName;
        }
        
        public Totals GetTotals(int userID)
        {
            var totals = from x in db.GetTable<Totals>()
                       where x.userID == userID
                       select x;
            return totals;
        }
    }
}
