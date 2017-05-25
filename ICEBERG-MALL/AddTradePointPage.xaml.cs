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
    /// Логика взаимодействия для AddTradePointPage.xaml
    /// </summary>
    public partial class AddTradePointPage : Page
    {
        Methods _methods;
        Category _category;
        public AddTradePointPage(Methods methods, Category category)
        {
            InitializeComponent();
            _methods = methods;
            _category = category;
            comboBox.ItemsSource = _methods.Categories;
        }
        
        private void buttonAddTradePointOk_Click(object sender, RoutedEventArgs e)
        {
            int number;
            double number1;
            if (string.IsNullOrWhiteSpace(textBoxAddTradePointName.Text))
            {
                MessageBox.Show("Введите название!");
                textBoxAddTradePointName.Focus();
                return;
            }
            if ((int.TryParse(textBoxAddTradePointName.Text, out number) == true))
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxAddTradePointName.Focus();
                return;
            }
            if(double.TryParse(textBoxAddTradePointName.Text, out number1) == true)
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxAddTradePointName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxAddTradePointDescription.Text))
            {
                MessageBox.Show("Введите описание!");
                textBoxAddTradePointDescription.Focus();
                return;
            }
            if ((int.TryParse(textBoxAddTradePointDescription.Text, out number) == true))
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxAddTradePointDescription.Focus();
                return;
            }
            if(double.TryParse(textBoxAddTradePointDescription.Text, out number1) == true)
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxAddTradePointDescription.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                MessageBox.Show("Выберите категорию!");
                comboBox.Focus();
                return;
            }
            if (comboBox.SelectedItem is Category && comboBox.ItemsSource != null)
            {
                TradePoint temp = new TradePoint(textBoxAddTradePointName.Text, textBoxAddTradePointDescription.Text);
                _methods.AddTradePoint(temp, comboBox.SelectedItem as Category);
                NavigationService.Navigate(new AdminPage(_methods, _category));
            }
        }

        private void buttonAddTradePointCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
