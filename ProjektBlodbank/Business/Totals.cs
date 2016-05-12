using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank.Business
{
    [Table(Name = "Totals")]
    class Totals
    {
        int userId;
        double totalBlood;
        TimeSpan totalDuration;
        int totalDonations;
        int savedLives;
        [Column(Storage ="userId")]
        public int UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }
        [Column(Storage ="totalBlood")]
        public double TotalBlood
        {
            get { return this.totalBlood; }
            set { this.totalBlood = value; }
        }
        [Column(Storage ="totalDuration")]
        public TimeSpan TotalDuration
        {
            get { return this.totalDuration; }
            set { this.totalDuration = value; }
        }
        [Column(Storage ="totalDonations")]
        public int TotalDonations
        {
            get { return this.totalDonations; }
            set { this.totalDonations = value; }
        }
        [Column(Storage ="savedLives")]
        public int SavedLives
        {
            get { return this.savedLives; }
            set { this.savedLives = value; }
        }
    }
}
