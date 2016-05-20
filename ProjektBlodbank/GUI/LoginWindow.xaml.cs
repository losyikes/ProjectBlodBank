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
        private int CreateUserGridHeight = 565;
        private int CreateUserGridWidth = 410;
        private List<TextBox> necesaryInputList;
        public LoginWindow()
        {
            InitializeComponent();
            necesaryInputList = new List<TextBox>();
            necesaryInputList.Add(CreateUserUserNameTbx);
            necesaryInputList.Add(CreateUserPasswordTbx);
            necesaryInputList.Add(CreateUserFirstNameTbx);
            necesaryInputList.Add(CreateUserLastNameTbx);
            necesaryInputList.Add(CreateUserCPRNumberTbx);
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            LoginController loginController = new LoginController();
            if (LoginUserNameTbx.Text == "" && LoginPasswordTbx.Password == "")
                MessageBox.Show("Indtast venlist et brugernavn og en adgangskode.");
            else if (LoginUserNameTbx.Text == "")
                MessageBox.Show("Indtast venlist et brugernavn.");
            else if (LoginPasswordTbx.Password == "")
                MessageBox.Show("Indtast venlist en adgangskode.");
            else if (loginController.Login(LoginUserNameTbx.Text, LoginPasswordTbx.Password) == false)
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
            this.Width = CreateUserGridWidth;
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
            bool missingInput = false;
            foreach (TextBox textBox in necesaryInputList)
            {
                if (textBox.Text == "")
                    missingInput = true;
            }
            if (missingInput == true)
                MessageBox.Show("Indtast venligst alle felter markeret med en *");
            else
            {
                passwordValidated = loginController.ValidatePassword(CreateUserPasswordTbx.Text, CreateUserRepeatPasswordTbx.Text);
                if (passwordValidated == false)
                    MessageBox.Show("Indtast venligst det samme kodeord to gange.");
                else
                {
                    bool newUserCreated = loginController.CreateNewUser(CreateUserFirstNameTbx.Text, CreateUserLastNameTbx.Text, CreateUserStreetNameTbx.Text,
                           CreateUserCityTbx.Text, CreateUserZipCodeTbx.Text, CreateUserCPRNumberTbx.Text, CreateUserUserNameTbx.Text,
                            CreateUserPasswordTbx.Text, CreateUserBloodTypeTbx.Text, CreateUserEmailTbx.Text, CreateUserPhoneNumberTbx.Text);
                    if (newUserCreated == false)
                        MessageBox.Show("Indtast venligst kun tal ved postnummer, CPR-nummer og telefonnummer.");
                    else
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.Close();
                    }
                }
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
