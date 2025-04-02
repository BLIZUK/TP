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


namespace TP.Windows.LB4
{


    /// <summary>
    /// Логика взаимодействия для Lb3.xaml
    /// </summary>


    public partial class Lb4 : Window
    {


        public Lb4()
        {
            InitializeComponent();
        }


        // Обработчик для кнопки "Задача 1"
        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            LB4.Tasks.LB4_1.lb4_1 lb3_1win = new()
            {
                Owner = this
            };
            lb3_1win.Show();
        }


        // Обработчик для кнопки "Задача 2"
        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            LB4.Tasks.LB4_2.lb4_2 lb3_2win = new()
            {
                Owner = this
            };
            lb3_2win.Show();
        }


        // Обработчик для кнопки "Задача 3"
        private void Task3Button_Click(object sender, RoutedEventArgs e)
        {
            LB4.Tasks.LB4_3.lb4_3 lb3_3win = new()
            {
                Owner = this
            };
            lb3_3win.Show();
        }
    }
}