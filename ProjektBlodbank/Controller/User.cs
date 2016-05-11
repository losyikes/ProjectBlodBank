using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank.Controller
{
    [Table(Name = "Customer")]
    class User
    {
        int userId;
        string firstname;
        string lastname;
        string streetname;
        string city;
        int zipCode;
        string cprNumber;
        string login;
        string password;
        string bloodtype;
        string email;
        string phoneNumber;
        DateTime nextDonation;
        EntitySet<Donation> donationList = new EntitySet<Donation>();
        string preferredBusLocation;
        [Column(IsPrimaryKey = true, Storage = "userId")]
        public int UserID {
            get { return this.userId; }
        }
        [Column(Storage = "firstname")]
        public string Firstname {
            get { return this.firstname; }
            set { this.firstname = value; }
        }
        [Column(Storage = "lastname")]
        public string Lastname {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
        [Column(Storage = "streetname")]
        public string Streetname {
            get { return this.streetname; }
            set { this.streetname = value; }
        }
        [Column(Storage = "city")]
        public string City {
            get { return this.city; }
            set { this.city = value; }
        }
        [Column(Storage = "zipCode")]
        public int ZipCode {
            get { return this.zipCode; }
            set { this.zipCode = value; }
        }
        [Column(Storage = "cprNumber")]
        public string CPRNumber {
            get { return this.cprNumber; }
            set { this.cprNumber = value; }
        }
        [Column(Storage ="login")]
        public string Login {
            get { return this.login; }
            set { this.login = value; }
        }
        [Column(Storage ="password")]
        public string Password {
            get { return this.password; }
            set { this.password = value; }
        }
        [Column(Storage ="bloodtype")]
        public string Bloodtype {
            get { return this.bloodtype; }
            set { this.bloodtype = value; }
        }
        [Column(Storage ="email")]
        public string Email {
            get { return this.email; }
            set { this.email = value; }
        }
        [Column(Storage ="phoneNumber")]
        public string PhoneNumber {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        [Column(Storage ="nextDonation")]
        public DateTime NextDonation {
            get { return this.nextDonation; }
            set { this.nextDonation = value; }
        }
        [Association(Storage ="donationList", OtherKey ="UserId")]
        public EntitySet<Donation> DonationList
        {
            get { return this.donationList; }
            set { this.donationList.Assign(value); }
        }
        [Column(Storage ="preferredBusLocation")]
        public string PreferredBusLocation
        {
            get { return this.preferredBusLocation; }
            set { this.preferredBusLocation = value; }
        }
    }
}
