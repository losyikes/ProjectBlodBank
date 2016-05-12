using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank.Business
{
    [Table(Name ="Donation")]
    class Donation
    {
        int id;
        int userId;
        double amount;
        string bloodbagNumber;
        string donationType;
        int bloodsugar;
        string donationLocation;
        DateTime donationDate;
        TimeSpan duration;
        
        [Column(IsPrimaryKey = true, Storage="id")]
        public int Id
        {
            get { return id; }
        }
        [Column(Storage ="userId")]
        public int UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }
        [Column(Storage ="amount")]
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        [Column(Storage = "bloodbagNumber")]
        public string BloodbagNumber
        {
            get { return this.bloodbagNumber; }
            set { this.bloodbagNumber = value; }
        }
        [Column(Storage ="donationType")]
        public string DonationType
        {
            get { return this.donationType; }
            set { this.donationType = value; }
        }
        [Column(Storage = "bloodsugar")]
        public int Bloodsugar
        {
            get { return this.bloodsugar; }
            set { this.bloodsugar = value; }
        }
        [Column(Storage = "donationLocation")]
        public string DonationLocation
        {
            get { return this.donationLocation; }
            set { this.donationLocation = value; }
        }
        [Column(Storage = "donationDate")]
        public DateTime DonationDate
        {
            get { return this.donationDate; }
            set { this.donationDate = value; }
        }
        [Column(Storage = "duration")]
        public TimeSpan Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
