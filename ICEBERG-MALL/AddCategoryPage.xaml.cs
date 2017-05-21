﻿using System;
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


        bool _addCategoryNameEntered = false;
        private void textBoxAddCategoryName_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!_addCategoryNameEntered)
            {
                textBoxAddCategoryName.Text = "";
                textBoxAddCategoryName.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void textBoxAddCategoryName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxAddCategoryName.Text))
                _addCategoryNameEntered = true;
            else
            {
                textBoxAddCategoryName.Text = "Введите название категории";
                _addCategoryNameEntered = false;
                textBoxAddCategoryName.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void buttonAddCategoryOk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddCategoryName.Text))
            {
                MessageBox.Show("Введите категорию!");
                textBoxAddCategoryName.Focus();
                return;
            }
            Category categoryNew = new Category(textBoxAddCategoryName.Text);
            _methods.AddCategory(categoryNew);
            NavigationService.Navigate(new AdminPage(_methods, _categories));
        }
    }
}
