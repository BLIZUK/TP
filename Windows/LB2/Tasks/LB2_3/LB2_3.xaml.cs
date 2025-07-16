using System;
using System.Text;
using System.Windows;

namespace TP.Windows.LB2.Tasks.Task3
{
    public partial class task3 : Window
    {
        public task3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем количество строк
                int rows = int.Parse(txtRows.Text);

                // Получаем диапазон случайных чисел
                int min = int.Parse(txtMin.Text);
                int max = int.Parse(txtMax.Text);

                // Создаем ступенчатый массив
                int[][] jaggedArray = new int[rows][];
                Random random = new Random();


                // Заполняем массив последовательными числами
                for (int i = 0; i < rows; i++)
                {
                    // Количество столбцов для текущей строки увеличивается на 1 для каждой строки
                    int currentCols = i + 1;

                    jaggedArray[i] = new int[currentCols];

                    for (int j = 0; j < currentCols; j++)
                    {
                        int number = random.Next(min, max);
                        jaggedArray[i][j] = number++; 
                    }
                }
                // Формируем строку для вывода
                StringBuilder output = new StringBuilder();
                for (int i = 0; i < jaggedArray.Length; i++)
                {
                    output.AppendLine(string.Join(" ", jaggedArray[i]));
                }

                // Выводим массив в TextBox
                txtOutput.Text = output.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
