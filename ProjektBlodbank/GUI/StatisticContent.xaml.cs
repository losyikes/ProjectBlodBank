using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for StatisticContent.xaml
    /// </summary>
    
    public partial class StatisticContent : UserControl
    {
        Controller statController = new Controller();

        
        public StatisticContent()
        {
            InitializeComponent();

            statController.LoadStats();



        }
    }
}



//            <Label x:Name="lblMemberDurationStat" Content="" HorizontalAlignment="Left" Margin="203,0,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblTotalDonationStat" Content="" HorizontalAlignment="Left" Margin="203,26,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblTotDonWholeStat" Content="" HorizontalAlignment="Left" Margin="203,52,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblTotDonPlasmaStat" Content="" HorizontalAlignment="Left" Margin="203,78,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblAmountDonatedStat" Content="" HorizontalAlignment="Left" Margin="203,104,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblAmDonWholeStat" Content="" HorizontalAlignment="Left" Margin="203,130,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblAmDonPlasmaStat" Content="" HorizontalAlignment="Left" Margin="203,156,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblTotalTimeDonatedStat" Content="" HorizontalAlignment="Left" Margin="203,182,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblTotTimeWholeStat" Content="" HorizontalAlignment="Left" Margin="203,208,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblTotTimePlasmaStat" Content="Label" HorizontalAlignment="Left" Margin="203,234,0,0" VerticalAlignment="Top" Width="155"/>
//            <Label x:Name="lblEmptyStat" Content="" HorizontalAlignment="Left" Margin="203,260,0,0" VerticalAlignment="Top" Width="155"/>
