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
    class Donation
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public int UserId { get; set; }
        [Column]
        public double Amount { get; set; }
        [Column]
        public string BloodbagNumber { get; set; }
        [Column]
        public string DonationType { get; set; }
        [Column]
        public double Bloodsugar { get; set; }
        [Column]
        public string DonationLocation { get; set; }
        [Column]
        public DateTime DonationDate { get; set; }
        [Column(DbType = "Time NOT NULL")]
        public TimeSpan Duration { get; set; }

    }
}
