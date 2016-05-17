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
    class BloodbankDataContext : DataContext
    {
        public BloodbankDataContext() : base("Data Source=ealdb1.eal.local;Initial Catalog=EJL21_DB;Persist Security Info=True;User ID=ejl21_usr;Password=Baz1nga21")
        {
            
        }
        public Table<User> User;
        public Table<Donation> Donation;
        public Table<Totals> Totals;
    }
}
