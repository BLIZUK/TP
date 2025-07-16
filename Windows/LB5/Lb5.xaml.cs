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
using System.Windows.Shapes;


namespace TP.Windows.LB5
{


    /// <summary>
    /// Логика взаимодействия для Lb3.xaml
    /// </summary>


    public partial class Lb5 : Window
    {


        public Lb5()
        {
            InitializeComponent();
        }


        // Обработчик для кнопки "Задача 1"
        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            LB5.Tasks.LB5_1.LB5_1 lb5_1win = new()
            {
                Owner = this
            };
            lb5_1win.Show();
        }


        // Обработчик для кнопки "Задача 2"
        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            LB5.Tasks.LB5_2.LB5_2 lb5_2win = new()
            {
                Owner = this
            };
            lb5_2win.Show();
        }
    }
}