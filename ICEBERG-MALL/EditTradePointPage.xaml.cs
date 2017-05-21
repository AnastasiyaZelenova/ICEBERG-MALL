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

        private void buttonAddTradePointOk_Click(object sender, RoutedEventArgs e)
        {
            //проверка полей
            _methods.EditTradePoint(_tradepoint, textBoxEditTradePointName.Text, textBoxEditTradePointDescription.Text);
            NavigationService.Navigate(new AdminPage(_methods, _category));
        }

    
    }
}
