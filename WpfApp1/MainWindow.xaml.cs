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


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ButtonWrap_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
          
            Registration.Visibility = Visibility.Visible;

        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {

            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible; 
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenuTwo_Click(object sender, RoutedEventArgs e)
        {

            ButtonOpenMenuTwo.Visibility = Visibility.Collapsed;
            ButtonCloseMenuTwo.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenuTwo_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenuTwo.Visibility = Visibility.Visible;
            ButtonCloseMenuTwo.Visibility = Visibility.Collapsed;
        }

        private void Aenter_Click(object sender, RoutedEventArgs e)
        {
           


        }
    }
}
