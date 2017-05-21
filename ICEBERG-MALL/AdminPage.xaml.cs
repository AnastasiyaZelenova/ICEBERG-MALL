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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        Methods _methods = new Methods();
        Category _category = new Category();

        public AdminPage(Methods methods, Category category)
        {
            InitializeComponent();
            listViewCategory.ItemsSource = _methods.Categories;
            _methods = methods;
            _category = category;
        }

        
        private void buttonAddCategory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCategoryPage(_methods,_category));
        }

        private void buttonRemoveCategory_Click(object sender, RoutedEventArgs e)
        {
            if (listViewCategory.SelectedIndex != -1)
            {
                _methods.DeleteCategory(listViewCategory.SelectedItem as Category);
                RefreshListView();
            }
        }

        private void RefreshListView()
        {
            listViewCategory.ItemsSource = null;
            listViewCategory.ItemsSource = _methods.Categories;
        }

        private void buttonEditCategory_Click(object sender, RoutedEventArgs e)
        {
            if(listViewCategory.SelectedIndex != -1)
            {
                Category chosen = listViewCategory.SelectedItem as Category;
                NavigationService.Navigate(new EditCategoryPage(_methods, chosen));
                RefreshListView();
            }
        }

        private void buttonRemoveTradePoint_Click(object sender, RoutedEventArgs e)
        {
            if (listViewTradePoint.SelectedIndex != -1)
            {
                _methods.DeleteTradePoint(listViewTradePoint.SelectedItem as TradePoint, listViewCategory.SelectedItem as Category);
                listViewTradePoint.Items.Refresh();
            }

        }

        private void buttonAddTradePoint_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTradePointPage(_methods, _category));
        }

        private void buttonEditTradePoint_Click(object sender, RoutedEventArgs e)
        {
            if(listViewTradePoint.SelectedIndex != -1)
            {
                NavigationService.Navigate(new EditTradePointPage(_methods, _category, listViewTradePoint.SelectedItem as TradePoint));
            }

        }

        bool _categoryEntered = false;
        private void textBoxCategory_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_categoryEntered)
            {
                textBoxCategory.Text = "";
                textBoxCategory.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void textBoxCategory_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxCategory.Text))
                _categoryEntered = true;
            else
            {
                textBoxCategory.Text = "Введите название категории";
                _categoryEntered = false;
                textBoxCategory.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
        bool _tradePointEntered = false;
        private void textBoxTradePoint_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_tradePointEntered)
            {
                textBoxTradePoint.Text = "";
                textBoxTradePoint.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void textBoxTradePoint_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTradePoint.Text))
                _tradePointEntered = true;
            else
            {
                textBoxTradePoint.Text = "Введите название магазина";
                _tradePointEntered = false;
                textBoxTradePoint.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void listViewCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonRemoveCategory.IsEnabled = listViewCategory.SelectedIndex != -1;
            buttonEditCategory.IsEnabled = listViewCategory.SelectedIndex != -1;

            if (listViewCategory.SelectedIndex != -1)
                listViewTradePoint.ItemsSource = (listViewCategory.SelectedItem as Category).TradePoints;
            else
                listViewTradePoint.ItemsSource = null;
        }

        private void listViewTradePoint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buttonRemoveTradePoint.IsEnabled = listViewTradePoint.SelectedIndex != -1;
            buttonEditTradePoint.IsEnabled = listViewTradePoint.SelectedIndex != -1;
        }
    }
}
