using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjektBlodbank.Business;
//nedenstående er temp using statements
using ProjektBlodbank.Data;

namespace ProjektBlodbank.GUI
{
    /// <summary>
    /// Interaction logic for RulesContent.xaml
    /// </summary>
    public partial class RulesContent : UserControl
    {
        //temp
        private BloodbankDataContext db;
        public RulesContent()
        {
            InitializeComponent();
            db = new BloodbankDataContext();
        }
        private void FillDbButton_Click(object sender, RoutedEventArgs e)
        {
            fillDatabase();
        }
        void fillDatabase()
        {
            /*
            User user = new User();
            user.Firstname = "Anders";
            user.Lastname = "And";
            user.Streetname = "Paradisæblevej 113";
            user.City = "Andeby";
            user.ZipCode = 5700;
            user.CPRNumber = 1245781245;
            user.Login = "anders";
            user.Password = "and";
            user.Bloodtype = "A+";
            user.Email = "andersand@andeby.dk";
            user.PhoneNumber = 12345678;
            user.NextPlasmaDonation = DateTime.Now.AddDays(30);
            user.NextWholeBloodDonation = DateTime.Now.AddDays(14);
            user.PreferredBusLocation = "Fåborg";
            db.User.InsertOnSubmit(user);
            db.SubmitChanges();
            */

            User user = new User();
            user.Firstname = "Andersine";
            user.Lastname = "And";
            user.Streetname = "Gåsestræde 113";
            user.City = "Andeby";
            user.ZipCode = 5700;
            user.CPRNumber = 1245781246;
            user.Login = "andersine";
            user.Password = "and";
            user.Bloodtype = "0+";
            user.Email = "andersineand@andeby.dk";
            user.PhoneNumber = 12345876;
            user.NextPlasmaDonation = DateTime.Now.AddDays(35);
            user.NextWholeBloodDonation = DateTime.Now.AddDays(10);
            user.PreferredBusLocation = "Fåborg";
            db.User.InsertOnSubmit(user);
            db.SubmitChanges();

            List<Donation> donationList = new List<Donation>();
            Donation donation = new Donation();
            donation.Amount = 450;
            donation.BloodbagNumber = "123";
            donation.Bloodsugar = 5.2;
            donation.DonationLocation = "Odense Sygehus Blodbank";
            donation.DonationDate = DateTime.Now.AddDays(-150);
            donation.Duration = new TimeSpan(0, 31, 0);
            donation.DonationType = "WholeBlood";
            donation.UserId = user.UserId;

            Donation donation2 = new Donation();
            donation2.Amount = 450;
            donation2.BloodbagNumber = "222";
            donation2.Bloodsugar = 4.2;
            donation2.DonationLocation = "Odense Sygehus Blodbank";
            donation2.DonationDate = DateTime.Now.AddDays(-120);
            donation2.DonationType = "WholeBlood";
            donation2.Duration = new TimeSpan(0, 39, 0);
            donation2.UserId = user.UserId;

            Donation donation5 = new Donation();
            donation5.Amount = 450;
            donation5.BloodbagNumber = "222";
            donation5.Bloodsugar = 4.2;
            donation5.DonationLocation = "Odense Sygehus Blodbank";
            donation5.DonationDate = DateTime.Now.AddDays(-90);
            donation5.DonationType = "WholeBlood";
            donation5.Duration = new TimeSpan(0, 39, 0);
            donation5.UserId = user.UserId;

            Donation donation3 = new Donation();
            donation3.Amount = 450;
            donation3.BloodbagNumber = "333";
            donation3.Bloodsugar = 4.5;
            donation3.DonationLocation = "Odense Sygehus Blodbank";
            donation3.DonationDate = DateTime.Now.AddDays(-60);
            donation3.DonationType = "WholeBlood";
            donation3.Duration = new TimeSpan(0, 41, 0);
            donation3.UserId = user.UserId;

            Donation donation4 = new Donation();
            donation4.Amount = 450;
            donation4.BloodbagNumber = "333";
            donation4.Bloodsugar = 4.5;
            donation4.DonationLocation = "Odense Sygehus Blodbank";
            donation4.DonationDate = DateTime.Now.AddDays(-30); ;
            donation4.DonationType = "WholeBlood";
            donation4.Duration = new TimeSpan(0, 41, 0);
            donation4.UserId = user.UserId;

            Donation donation6 = new Donation();
            donation6.Amount = 450;
            donation6.BloodbagNumber = "222";
            donation6.Bloodsugar = 4.2;
            donation6.DonationLocation = "Odense Sygehus Blodbank";
            donation6.DonationDate = DateTime.Now;
            donation6.DonationType = "Plasma";
            donation6.Duration = new TimeSpan(0, 39, 0);
            donation6.UserId = user.UserId;

            donationList.Add(donation);
            donationList.Add(donation2);
            donationList.Add(donation3);
            donationList.Add(donation4);
            donationList.Add(donation5);
            donationList.Add(donation6);

            Totals totals = new Totals();
            totals.UserId = user.UserId;
            totals.TotalBlood = 2000;
            totals.TotalDuration = new TimeSpan(5, 30, 0);
            totals.TotalDonations = 4;
            totals.SavedLives = 5;
            //user.Total = totals;
            user.DonationList = donationList;
            db.Donation.InsertAllOnSubmit(donationList);
            db.Totals.InsertOnSubmit(totals);

            db.Log = Console.Out;
            db.SubmitChanges();
        }
    }
}
