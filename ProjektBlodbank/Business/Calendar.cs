using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Globalization;
using ProjektBlodbank.GUI;

namespace ProjektBlodbank
{
    class Calendar
    {
        int month;
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value > 12)
                {
                    month = 1;
                    year++;
                }
                else if (value < 1)
                {
                    month = 12;
                    year--;
                }
                else
                {
                    month = value;
                }
            }
        }
        int year = 2016;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public CalendarContent Main;
        private delegate void UpdateGrid();
        public double Height { get; set; }
        public double Width { get; set; }

        public Calendar(double height, double width)
        {
            Height = height;
            Width = width;
            DateTime currentTime = DateTime.Today;
            month = currentTime.Month;
        }

        public Grid createGrid()
        {
            Grid calendarGrid = new Grid();
            calendarGrid.Height = Height;
            calendarGrid.Width = Width;
            calendarGrid.VerticalAlignment = VerticalAlignment.Top;
            calendarGrid.HorizontalAlignment = HorizontalAlignment.Left;
            fillCalendarDays(calendarGrid);
            fillCalendarHeader(Month, calendarGrid);
            return calendarGrid;
        }

        public void ChangeMonth(string direction)
        {
            if (direction == "Next")
            {
                Month++;
                UpdateGrid clearGrid = () => Main.CalendarContentGrid.Children.Clear();
                UpdateGrid updateGrid = () => Main.CalendarContentGrid.Children.Add(createGrid());
                Main.Dispatcher.Invoke(clearGrid, DispatcherPriority.Render);
                Main.Dispatcher.Invoke(updateGrid, DispatcherPriority.Render);
            }
            else if (direction == "Previous")
            {
                Month--;
                UpdateGrid clearGrid = () => Main.CalendarContentGrid.Children.Clear();
                UpdateGrid updateGrid = () => Main.CalendarContentGrid.Children.Add(createGrid());
                Main.Dispatcher.Invoke(clearGrid, DispatcherPriority.Render);
                Main.Dispatcher.Invoke(updateGrid, DispatcherPriority.Render);
            }
        }

        void fillCalendarDays(Grid grid)
        {
            int labelCount = 0;
            int labelRow = 0;
            int date = 1;
            for (int week = 0; week < 6; week++)
            {

                for (int day = 0; day < 7; day++)
                {
                    Label weekday = new Label();
                    weekday.VerticalAlignment = VerticalAlignment.Top;
                    weekday.HorizontalAlignment = HorizontalAlignment.Left;
                    weekday.Width = (grid.Width - 10) / 7;
                    weekday.Height = (grid.Height - 80) / 6;
                    Thickness margin = new Thickness();
                    margin.Left = weekday.Width * day;
                    margin.Top = weekday.Height * (labelRow + 1);
                    weekday.Margin = margin;

                    DateTime firstOfChosenMonth = new DateTime(Year, Month, 1);
                    int monthsFirstWeekDay = (int)firstOfChosenMonth.DayOfWeek;
                    labelCount++;
                    if (monthsFirstWeekDay < labelCount && DateTime.DaysInMonth(Year, Month) >= date)
                    {
                        weekday.BorderBrush = Brushes.DarkGray;
                        if (date == 1 || (day == 0 && week == 1 && monthsFirstWeekDay != 0))
                            weekday.BorderThickness = new Thickness(1);
                        else if (day == 0)
                            weekday.BorderThickness = new Thickness(1, 0, 1, 1);
                        else if (date < 8)
                            weekday.BorderThickness = new Thickness(0, 1, 1, 1);
                        else
                            weekday.BorderThickness = new Thickness(0, 0, 1, 1);

                        weekday.Content = date.ToString();
                        date++;
                    }
                    else
                    {
                        weekday.Content = "";
                    }
                    grid.Children.Add(weekday);
                }
                labelRow++;
            }
        }

        void fillCalendarHeader(int monthNumber, Grid grid)
        {
            Button prevMonthBtn = new Button();
            prevMonthBtn.Width = 25;
            prevMonthBtn.Height = 25;
            prevMonthBtn.VerticalAlignment = VerticalAlignment.Top;
            prevMonthBtn.HorizontalAlignment = HorizontalAlignment.Left;
            prevMonthBtn.Margin = new Thickness(100, 10, 0, 0);
            prevMonthBtn.Content = "<<";
            prevMonthBtn.Click += new RoutedEventHandler(prevMonthBtnClick);

            Button nextMonthBtn = new Button();
            nextMonthBtn.Width = 25;
            nextMonthBtn.Height = 25;
            nextMonthBtn.VerticalAlignment = VerticalAlignment.Top;
            nextMonthBtn.HorizontalAlignment = HorizontalAlignment.Right;
            nextMonthBtn.Margin = new Thickness(0, 10, 100, 0);
            nextMonthBtn.Content = ">>";
            nextMonthBtn.Click += new RoutedEventHandler(nextMonthBtnClick);

            Label monthName = new Label();
            monthName.Height = 50;
            monthName.VerticalAlignment = VerticalAlignment.Top;
            monthName.HorizontalAlignment = HorizontalAlignment.Center;
            monthName.Margin = new Thickness(0, 10, 0, 0);

            monthName.Content = new DateTime(2010, monthNumber, 1).ToString("MMMM", new CultureInfo("da-DK")).ToUpper();
            grid.Children.Add(prevMonthBtn);
            grid.Children.Add(nextMonthBtn);
            grid.Children.Add(monthName);
        }

        void prevMonthBtnClick(object sender, EventArgs e)
        {
            ChangeMonth("Previous");
        }

        void nextMonthBtnClick(object sender, EventArgs e)
        {
            ChangeMonth("Next");
        }
    }
}
