using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using ProjektBlodbank.Business;

namespace ProjektBlodbank.Data
{
    class BloodbankData : DataContext
    {
        public BloodbankData() : base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True")
        {
            
        }
        public Table<User> User;
        public Table<Donation> Donation;
        public Table<Totals> Totals;
    }
}
