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
using System.Windows.Shapes;
using ProjektBlodbank.Business;
using ProjektBlodbank.Data;

namespace ProjektBlodbank.GUI
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private int LoginGridHeight = 270;
        private int CreateUserGridHeight = 535;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginController loginController = new LoginController();
            if (LoginUserNameTbx.Text == "" && LoginPasswordTbx.Text == "")
                MessageBox.Show("Indtast venlist et brugernavn og en adgangskode.");
            else if (LoginUserNameTbx.Text == "")
                MessageBox.Show("Indtast venlist et brugernavn.");
            else if (LoginPasswordTbx.Text == "")
                MessageBox.Show("Indtast venlist en adgangskode.");
            else if (loginController.Login(LoginUserNameTbx.Text, LoginPasswordTbx.Text) == false)
                MessageBox.Show("Indtast venlist gyldigt brugernavn og adgangskode.");
            else
            {
                UserData userdata = new UserData();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void NewUserBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Height = CreateUserGridHeight;
            CreateUserGrid.Visibility = Visibility.Visible;
            LoginGrid.Visibility = Visibility.Hidden;
            
        }

        private void ForgotPasswordBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateUserBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginController loginController = new LoginController();
            bool passwordValidated;
            passwordValidated = loginController.ValidatePassword(CreateUserPasswordTbx.Text, CreateUserRepeatPasswordTbx.Text);
            if (passwordValidated == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Height = LoginGridHeight;
            CreateUserGrid.Visibility = Visibility.Hidden;
            LoginGrid.Visibility = Visibility.Visible;
        }
    }
}
