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

namespace books.page
{
    /// <summary>
    /// Логика взаимодействия для BookPage.xaml
    /// </summary>
    public partial class BookPage : Page
    {
      
        public BookPage()
        {
            InitializeComponent();
            LVService.ItemsSource = BaseClass.Base.Books.ToList();
            
        }

  

        private void Button_Click(object sender, RoutedEventArgs e)// переход в корзину
        {
            FrameClass.FrameMain.Navigate(new basketPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
