using System.Windows;
using System.Windows.Controls;
using TP.Windows.LB2.Tasks.Task1;
using TP.Windows.LB4.Tasks;

namespace TP.Windows.LB4
{
    public partial class Lb4 : Window
    {
        public Lb4()
        {
            InitializeComponent();
            NavigateToTask1(null, null); // Загрузить первую задачу по умолчанию
        }

        private void NavigateToTask1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.LB4_1.lb4_1());
        }

        private void NavigateToTask2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.LB4_1.lb4_1());
        }

        private void NavigateToTask3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Tasks.LB4_1.lb4_1());
        }
    }
}