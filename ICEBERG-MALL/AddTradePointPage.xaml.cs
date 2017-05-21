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
        bool _addTradePointNameEntered = false;
        private void textBoxAddTradePointName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_addTradePointNameEntered)
            {
                textBoxAddTradePointName.Text = "";
                textBoxAddTradePointName.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void textBoxAddTradePointName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddTradePointName.Text))
                _addTradePointNameEntered = true;
            else
            {
                textBoxAddTradePointName.Text = "Название";
                _addTradePointNameEntered = false;
                textBoxAddTradePointName.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
        bool _addTradePointDescriptionEntered = false;
        private void textBoxAddTradePointDescription_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_addTradePointDescriptionEntered)
            {
                textBoxAddTradePointDescription.Text = "";
                textBoxAddTradePointDescription.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void textBoxAddTradePointDescription_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddTradePointDescription.Text))
                _addTradePointDescriptionEntered = true;
            else
            {
                textBoxAddTradePointDescription.Text = "Описание";
                _addTradePointDescriptionEntered = false;
                textBoxAddTradePointDescription.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void buttonAddTradePointOk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddTradePointName.Text))
            {
                MessageBox.Show("Введите название!");
                textBoxAddTradePointName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxAddTradePointDescription.Text))
            {
                MessageBox.Show("Введите описание!");
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
    }
}
