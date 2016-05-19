using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using ProjektBlodbank.GUI;

namespace ProjektBlodbank
{
    class Statistics
    {
        public TimeSpan memberDurationStat { get; set; }
        public int TotalDonationStat { get; set; }
        public int TotDonWholeStat { get; set; }
        public int TotDonPlasmaStat { get; set; }
        public int AmountDonatedStat { get; set; }
        public int AmDonWholeStat { get; set; }
        public int AmDonPlasmaStat { get; set; }
        public int TotalTimeDonatedStat { get; set; }
        public int TotTimeWholeStat { get; set; }
        public int TotTimePlasmaStat { get; set; }

        

        public Statistics()
        {
           
        }





        //public Grid CreateGrid()
        //{
        //    Uri uriChart_bg = new Uri("pack://application:,,,/ProjektBlodbank;component/Resources/chart_bg.png", UriKind.RelativeOrAbsolute);
        //    BitmapImage chartBgBmp = new BitmapImage(uriChart_bg);
        //    Image chartBgImg = new Image();
        //    chartBgImg.Source = chartBgBmp;

        //    Grid grid = new Grid();
        //    grid.Children.Add(chartBgImg);
        //    // Test Code ting
        //    int[] columnHeights = new int[5] { 160, 120, 180, 200, 300 };
        //    int marginLeft = 40;
        //    for (int i = 0; i <= 15; i++)
        //    {
        //        Random rnd = new Random();
        //        int position = rnd.Next(0, 5);
        //        Thread.Sleep(100);
        //        CreateColumn(columnHeights[position], marginLeft, grid);
        //        marginLeft = marginLeft + 20;
        //    }
        //    return grid;
        //}
        //void CreateColumn(int height,int marginLeft, Grid grid)
        //{
            
        //    Uri uriRodSojle = new Uri("pack://application:,,,/Resources/rod_sojle.png");
        //    BitmapImage rodSojleBmp = new BitmapImage(uriRodSojle);
        //    Image sojleImg = new Image();
        //    sojleImg.Source = rodSojleBmp;
        //    sojleImg.Height = height;
        //    sojleImg.Width = 10;
        //    sojleImg.Stretch = Stretch.None;
        //    sojleImg.VerticalAlignment = VerticalAlignment.Bottom;
        //    sojleImg.HorizontalAlignment = HorizontalAlignment.Left;

        //    sojleImg.Margin = new Thickness(marginLeft, 0, 0, 22);
        //    grid.Children.Add(sojleImg);

        //}
    }
}
