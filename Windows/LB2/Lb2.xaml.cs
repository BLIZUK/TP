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

namespace TP.Windows.LB2
{
    /// <summary>
    /// Логика взаимодействия для Lb2.xaml
    /// </summary>
    public partial class Lb2 : Window
    {

        public Lb2()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, RoutedEventArgs e)
        {
            LB2.Tasks.Task1.task1 Lb2task1win = new Tasks.Task1.task1();
            Lb2task1win.Owner = this;
            Lb2task1win.Show();
        }

        private void Task2_Click(object sender, RoutedEventArgs e)
        {
            LB2.Tasks.Task2.task2 Lb2task2win = new Tasks.Task2.task2();
            Lb2task2win.Owner = this;
            Lb2task2win.Show();

        }

        private void Task3_Click(object sender, RoutedEventArgs e)
        {
            LB2.Tasks.Task3.task3 Lb2task3win = new Tasks.Task3.task3();
            Lb2task3win.Owner = this;
            Lb2task3win.Show();
        }
    }
}
