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
    /// Логика взаимодействия для GuestPage.xaml
    /// </summary>
    public partial class GuestPage : Page
    {
        Methods _methods = new Methods();
        Category _category = new Category();

        public GuestPage(Methods methods, Category category)
        {
            InitializeComponent();
            listViewCategory.ItemsSource = _methods.Categories;
            _methods = methods;
            _category = category;
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
            if (listViewCategory.SelectedIndex != -1)
            {
                listViewTradePoint.ItemsSource = (listViewCategory.SelectedItem as Category).TradePoints;
            }
            else
            {
                listViewTradePoint.ItemsSource = null;
            }
        }

        private void textBoxCategory_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listViewCategory == null)
            {
                return;
            }

            else
            {
                string input = textBoxCategory.Text;
                if (input == "")
                {
                    listViewCategory.ItemsSource = _methods.Categories;
                }
                else
                {
                    listViewCategory.ItemsSource = _methods.SearchCategory(input);
                }
            }

        }

        private void textBoxTradePoint_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (listViewCategory == null)
            {
                return;
            }

            if (listViewCategory.SelectedIndex != -1)
            {
                string input = textBoxTradePoint.Text;
                Category chosen = listViewCategory.SelectedItem as Category;
                if (input == "")
                {
                    listViewTradePoint.ItemsSource = chosen.TradePoints;
                }
                else
                {
                    listViewTradePoint.ItemsSource = _methods.SearchTradePoint(chosen, input);
                }
            }
        }
    }
}
