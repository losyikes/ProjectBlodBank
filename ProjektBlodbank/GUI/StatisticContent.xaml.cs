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

namespace ProjektBlodbank.GUI
{
    /// <summary>
    /// Interaction logic for StatisticContent.xaml
    /// </summary>
    
    public partial class StatisticContent : UserControl
    {
        Controller chart = new Controller();
        public StatisticContent()
        {
            InitializeComponent();
            
            
            
            
            //chart.statContent = this;




            //Grid statGrid = chart.CreateGrid();
            //StatisticsContentGrid.Children.Add(statGrid);
        }
    }
}
