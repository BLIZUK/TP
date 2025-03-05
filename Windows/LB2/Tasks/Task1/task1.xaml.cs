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

namespace TP.Windows.LB2.Tasks.Task1
{
    /// <summary>
    /// Логика взаимодействия для task1.xaml
    /// </summary>
    public partial class task1 : Window
    {
        public task1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем длину массива
                int length = int.Parse(lenArr.Text);
                double[] array = new double[length];

                // Читаем массив из текстового поля
                string[] input = inputArr.Text.Split(new[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < length; i++)
                {
                    array[i] = double.Parse(input[i]);
                }

                // Вычисляем сумму положительных элементов
                double sum = array.Where(x => x > 0).Sum();
                txtSum.Text = sum.ToString();

                // Находим индексы максимального и минимального по модулю элементов
                int maxIndex = 0, minIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (Math.Abs(array[i]) > Math.Abs(array[maxIndex])) maxIndex = i;
                    if (Math.Abs(array[i]) < Math.Abs(array[minIndex])) minIndex = i;
                }

                // Вычисляем произведение элементов между max и min по модулю
                double product = 1;
                int start = Math.Min(maxIndex, minIndex) + 1;
                int end = Math.Max(maxIndex, minIndex);
                for (int i = start; i < end; i++)
                {
                    product *= array[i];
                }
                txtProduct.Text = product.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем длину массива
                int length = int.Parse(lenArr.Text);
                double[] array = new double[length];

                // Читаем массив из текстового поля
                string[] input = inputArr.Text.Split(new[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < length; i++)
                {
                    array[i] = double.Parse(input[i]);
                }

                // Упорядочиваем массив по убыванию
                Array.Sort(array);
                Array.Reverse(array);

                // Выводим упорядоченный массив
                txtSortedArray.Text = string.Join(Environment.NewLine, array);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}