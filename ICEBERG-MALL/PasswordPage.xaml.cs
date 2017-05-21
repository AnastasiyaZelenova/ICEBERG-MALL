using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace ICEBERG_MALL
{
    /// <summary>
    /// Логика взаимодействия для PasswordPage.xaml
    /// </summary>
    public partial class PasswordPage : Page
    {
        Methods _methods = new Methods();
        Category _category = new Category();
        public PasswordPage()
        {
            InitializeComponent();
            textBoxLogin.Focus();

        }
        private string CalculateHash(string password)
        {
            MD5 md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
            return Convert.ToBase64String(hash);
        }


        private void Page_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Using keyboard handling on the page level
            if (e.Key == Key.Enter)
                buttonPassword_Click(null, null);
        }

        private void buttonPassword_Click(object sender, RoutedEventArgs e)
        {
            var hash = CalculateHash("12345");

            //if (textBoxLogin.Text == "zelenova" && CalculateHash(passwordBox.Password) == hash)
            NavigationService.Navigate(new AdminPage(_methods, _category));
            /*else
                MessageBox.Show("Incorrect login/password");*/
        }

        private void buttonPasswordCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

