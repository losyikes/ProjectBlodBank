﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBlodbank.Business
{
    [Table]
    class User
    {
        EntitySet<Donation> donationList = new EntitySet<Donation>();
        EntityRef<Totals> totals = new EntityRef<Totals>();
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int UserId { get; set; }
        [Column]
        public string Firstname {get; set;}
        [Column]
        public string Lastname { get; set; }
        [Column]
        public string Streetname { get; set; }
        [Column]
        public string City { get; set; }
        [Column]
        public int ZipCode { get; set; }
        [Column]
        public int CPRNumber { get; set; }
        [Column]
        public string Login { get; set; }
        [Column]
        public string Password { get; set; }
        [Column]
        public string Bloodtype { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public int PhoneNumber { get; set; }
        [Column]
        public DateTime NextPlasmaDonation { get; set; }
        [Column]
        public DateTime NextWholeBloodDonation { get; set; }
        [Association(Name = "User_Donation", IsForeignKey = true, Storage ="donationList", ThisKey = "UserId", OtherKey = "UserId")]
        public ICollection<Donation> DonationList
        {
            get { return this.donationList; }
            set { this.donationList.Assign(value); }
        }
        //[Column(Storage = "preferredBusLocation")]
        [Column]
        public string PreferredBusLocation { get; set; }
        //[Association(Name = "User_Totals", Storage = "totals", IsForeignKey = true, ThisKey = "UserId", OtherKey = "UserId")]
        //public Totals Total
        //{
        //    get { return this.totals.Entity; }
        //    set { this.totals.Entity = value; }
        //}
        [Column]
        public DateTime RegisteredDate { get; set; }

        public User()
        {
            
        }
        
        public User(string firstName, string lastName, string streetName, string city, int zipCode,
            int cPRNumber, string username, string password, string bloodtype, string email, int phoneNumber)
        {
            Firstname = firstName;
            Lastname = lastName;
            Streetname = streetName;
            City = city;
            ZipCode = zipCode;
            CPRNumber = cPRNumber;
            Login = username;
            Password = password;
            Bloodtype = bloodtype;
            Email = email;
            PhoneNumber = phoneNumber;
            NextPlasmaDonation = DateTime.Now.AddDays(25); // midlertidig kode
            NextWholeBloodDonation = DateTime.Now.AddDays(60); // midlertidig kode
            RegisteredDate = DateTime.Now;
        }
    }
}
