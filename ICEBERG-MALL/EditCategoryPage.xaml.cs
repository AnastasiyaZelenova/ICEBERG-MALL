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
    /// Логика взаимодействия для EditCategoryPage.xaml
    /// </summary>
    public partial class EditCategoryPage : Page
    {
        Methods _methods;
        Category _category;
        public EditCategoryPage(Methods methods, Category category)
        {
            InitializeComponent();
            _methods = methods;
            _category = category;
            textBoxEditCategory.Text = _category.NameCategory;
        }
       

        private void buttonEditCategoryOk_Click(object sender, RoutedEventArgs e)
        {
            int number;
            double number1;
            if (string.IsNullOrWhiteSpace(textBoxEditCategory.Text))
            {
                MessageBox.Show("Введите категорию!");
                textBoxEditCategory.Focus();
                return;
            }
            if ((int.TryParse(textBoxEditCategory.Text, out number) == true))
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxEditCategory.Focus();
                return;
            }
            if (double.TryParse(textBoxEditCategory.Text, out number1) == true)
            {
                MessageBox.Show("Данные введены неверно!");
                textBoxEditCategory.Focus();
                return;
            }
            _methods.EditCategory(_category, textBoxEditCategory.Text);
            NavigationService.Navigate(new AdminPage(_methods, _category));
        }

        private void buttonEditCategoryCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
