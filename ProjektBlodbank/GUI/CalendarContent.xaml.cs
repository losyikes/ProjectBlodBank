using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
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
    /// Interaction logic for CalendarContent.xaml
    /// </summary>
    public partial class CalendarContent : UserControl
    {
        Calendar calendar = new Calendar(420, 430);
        public CalendarContent()
        {
            InitializeComponent();
            calendar.Main = this;
            Grid calendarGrid = calendar.createGrid();
            CalendarContentGrid.Children.Add(calendarGrid);
        }
    }
}
