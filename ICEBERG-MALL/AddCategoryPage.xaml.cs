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
    /// Логика взаимодействия для AddCategoryPage.xaml
    /// </summary>
    public partial class AddCategoryPage : Page
    {
        Methods _methods;
        Category _categories;
        public AddCategoryPage(Methods methods, Category categories)
        {
            InitializeComponent();
            _methods = methods;
            _categories = categories;
        }

        private void buttonAddCategoryOk_Click(object sender, RoutedEventArgs e)
        {
            int number;
            double number1;
            if (string.IsNullOrWhiteSpace(textBoxAddCategoryName.Text))
            {
                MessageBox.Show("Введите категорию!");
                textBoxAddCategoryName.Focus();
                return;
            }
            if ((int.TryParse(textBoxAddCategoryName.Text, out number) == true))
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxAddCategoryName.Focus();
                return;
            }
            if (double.TryParse(textBoxAddCategoryName.Text, out number1) == true)
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxAddCategoryName.Focus();
                return;
            }

            Category categoryNew = new Category(textBoxAddCategoryName.Text);
            _methods.AddCategory(categoryNew);
            NavigationService.Navigate(new AdminPage(_methods, _categories));
        }

        private void buttonAddCategoryCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        
    }
}
