using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank.Business
{
    [Table]
    class Totals
    {
        
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int UserId{ get; set; }
        [Column]
        public double TotalBlood{ get; set; }
        [Column(DbType = "Time NOT NULL")]
        public TimeSpan TotalDuration { get; set; }
        [Column]
        public int TotalDonations { get; set; }
        [Column]
        public int SavedLives { get; set; }
    }
}
