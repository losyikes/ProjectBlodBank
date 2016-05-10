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

        /*
        Uncomment when User class is added

        public User GetUser(int userID)
        {
            var user = from x in db.GetTable<User>()
                     where x.userID == userID
                     select x;
            return user;
        }
        */
    }
}
