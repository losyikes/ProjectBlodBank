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

namespace ProjektBlodbank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Grid> gridList = new List<Grid>();
        public MainWindow()
        {
            InitializeComponent();
            gridList.Add(StartContentGrid);
            gridList.Add(SocialContentGrid);
            gridList.Add(StatisticContentGrid);
            gridList.Add(RulesContentGrid);
            gridList.Add(CalendarContentGrid);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            showGrid(StartContentGrid);
        }

        private void CalenderButton_Click(object sender, RoutedEventArgs e)
        {
            showGrid(CalendarContentGrid);
        }

        private void StatisticButton_Click(object sender, RoutedEventArgs e)
        {
            showGrid(StatisticContentGrid);
        }

        private void SocialButton_Click(object sender, RoutedEventArgs e)
        {
            showGrid(SocialContentGrid);
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            showGrid(RulesContentGrid);
        }
        void showGrid(Grid chosenGrid)
        {
            foreach(Grid grid in gridList)
            {
                if (chosenGrid == grid)
                    grid.Visibility = Visibility.Visible;
                else
                    grid.Visibility = Visibility.Hidden;
            }
        }
    }
}
