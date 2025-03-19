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

namespace TP.Windows.LB3
{
    /// <summary>
    /// Логика взаимодействия для Lb3.xaml
    /// </summary>
    public partial class Lb3 : Window
    {
        public Lb3()
        {
            InitializeComponent();
        }
        private void Task1Button_Click(object sender, RoutedEventArgs e)
        {
            LB3.lb3_1 lb3_1win = new LB3.lb3_1();
            lb3_1win.Owner = this;
            lb3_1win.Show();
        }

        // Обработчик для кнопки "Задача 2"
        private void Task2Button_Click(object sender, RoutedEventArgs e)
        {
            LB3.lb3_2 lb3_2win = new LB3.lb3_2();
            lb3_2win.Owner = this;
            lb3_2win.Show();
        }
    }
}