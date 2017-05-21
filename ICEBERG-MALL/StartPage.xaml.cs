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

namespace ICEBERG_MALL
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        Methods _methods = new Methods();
        Category _category = new Category();
        public StartPage()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PasswordPage());
        }

        private void buttonUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuestPage(_methods, _category));
        }
    }
}
