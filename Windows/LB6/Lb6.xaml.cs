using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace TP.Windows.LB6
{
    /// <summary>
    /// Логика взаимодействия для Lb6.xaml
    /// </summary>
    public partial class Lb6 : Window
    {
        HexCounter hexCounter;

        public Lb6()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            min.Text = (hexCounter.min)ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
