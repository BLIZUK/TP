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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TP.Windows.LB4.Tasks.LB4_1
{


    /// <summary>
    /// Логика взаимодействия для LB4_1.xaml
    /// </summary>
   
    
    public partial class lb4_1 : Page
    {
        public lb4_1()
        {
            InitializeComponent();
        }


        private void CheckSum_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double[] numbers = InputNumbers.Text.Split(' ')
                    .Select(double.Parse)
                    .Where(x => x < 20.5)
                    .ToArray();

                double sum = numbers.Sum();
                ResultText.Text = sum <= 50 ?
                    "Сумма НЕ превышает 50" :
                    "Сумма превышает 50";
            }
            catch
            {
                ResultText.Text = "Ошибка ввода!";
            }
        }
    }
}