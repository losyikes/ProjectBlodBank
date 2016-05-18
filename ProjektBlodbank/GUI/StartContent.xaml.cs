﻿using System;
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

namespace ProjektBlodbank.GUI
{
    /// <summary>
    /// Interaction logic for StartContent.xaml
    /// </summary>
    public partial class StartContent : UserControl
    {
        Controller start = new Controller();
        public StartContent()
        {
            InitializeComponent();

            lblWelcome.Content = "Hej " + start.LoggedInUser();
            

        }
    }
}


//public DateTime GetLastDonationDate(string type, User user)
//{
//    DateTime date = Convert.ToDateTime(from x in db.Donation
//                                       where x.UserId == user.UserId
//                                       group x by x.DonationDate into grp
//                                       select grp.OrderByDescending(g => g.DonationDate).FirstOrDefault().DonationDate);

//    return date;
//}