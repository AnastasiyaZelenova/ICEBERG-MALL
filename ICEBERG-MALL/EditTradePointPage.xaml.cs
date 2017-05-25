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
    /// Логика взаимодействия для EditTradePointPage.xaml
    /// </summary>
    public partial class EditTradePointPage : Page
    {
        Methods _methods;
        Category _category;
        TradePoint _tradepoint;

        public EditTradePointPage(Methods methods, Category category, TradePoint tradepoint)
        {
            InitializeComponent();
            _methods = methods;
            _category = category;
            _tradepoint = tradepoint;
            comboBox.ItemsSource = _methods.Categories;
            textBoxEditTradePointDescription.Text = _tradepoint.Description;
            textBoxEditTradePointName.Text = _tradepoint.Name;
        }

        private void buttonEditTradePointOk_Click(object sender, RoutedEventArgs e)
        {
            int number;
            double number1;
            if (string.IsNullOrWhiteSpace(textBoxEditTradePointName.Text))
            {
                MessageBox.Show("Введите имя!");
                textBoxEditTradePointName.Focus();
                return;
            }
            if ((int.TryParse(textBoxEditTradePointName.Text, out number) == true))
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxEditTradePointName.Focus();
                return;
            }
            if (double.TryParse(textBoxEditTradePointName.Text, out number1) == true)
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxEditTradePointName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxEditTradePointDescription.Text))
            {
                MessageBox.Show("Введите описание!");
                textBoxEditTradePointDescription.Focus();
                return;
            }
            if ((int.TryParse(textBoxEditTradePointDescription.Text, out number) == true))
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxEditTradePointDescription.Focus();
                return;
            }
            if (double.TryParse(textBoxEditTradePointDescription.Text, out number1) == true)
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxEditTradePointDescription.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                MessageBox.Show("Выберите категорию!");
                comboBox.Focus();
                return;
            }
            _methods.EditTradePoint(_tradepoint, textBoxEditTradePointName.Text, textBoxEditTradePointDescription.Text);
            NavigationService.Navigate(new AdminPage(_methods, _category));
        }

        private void buttonEditTradePointCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
