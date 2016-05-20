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
using ProjektBlodbank.Data;
using System.ComponentModel;

namespace ProjektBlodbank.GUI
{
    /// <summary>
    /// Interaction logic for StartContent.xaml
    /// </summary>
    public partial class StartContent : UserControl
    {
        Controller controller = new Controller();
        Start start = new Start();

        public StartContent()
        {
            InitializeComponent();

            lblWelcome.Content = "Hej " + controller.LoggedInUser();
            lblCount.Content = start.Countdown().Days.ToString();
            lblCount1WB.Content = start.CountdownWB().Days.ToString();

        }

        private void ComboBoxLocation_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = controller.GetBusStops();
                        
            var comboBox = sender as ComboBox;

            comboBox.ItemsSource = data;

            // ... Make the first item selected.
            if (UserData.LoggedInUser.PreferredBusLocation!=null)
            {
                int index = 0;
                bool keepRunning = true;
                while (keepRunning && index < data.Count)
                {
                    if (data[index] == UserData.LoggedInUser.PreferredBusLocation)
                    {
                        keepRunning = false;
                    }
                    else
                    {
                        index++;
                    }   
                }
                comboBox.SelectedIndex = index;
            }
            else
            {
                comboBox.SelectedIndex = 0;
            }
            



        }

        private void ComboBoxLocation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBoxLocation = sender as ComboBox;

            comboBoxDate.SelectedIndex = 0;
            comboBoxDate.ItemsSource = controller.GetBusTimes();
                        
            //ComboBoxDate_Loaded(sender, e);
        }

        private void ComboBoxDate_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> dataDate = controller.GetBusTimes();

            var comboBoxDate = sender as ComboBox;

            comboBoxDate.ItemsSource = dataDate;
        }
        private void ComboBoxDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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