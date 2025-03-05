using System;
using System.Linq;
using System.Windows;

namespace TP.Windows.LB2.Tasks.Task2
{
    public partial class task2 : Window
    {
        public task2()
        {
            InitializeComponent();
        }

        private int[,] ParseMatrix(string input, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            string[] lines = input.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < rows; i++)
            {
                string[] elements = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(elements[j]);
                }
            }

            return matrix;
        }

        private int CountZeroFreeColumns(int[,] matrix, int rows, int cols)
        {
            int count = 0;
            for (int j = 0; j < cols; j++)
            {
                bool hasZero = false;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }
                if (!hasZero) count++;
            }
            return count;
        }

        private int CalculateRowCharacteristic(int[,] matrix, int row, int cols)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[row, j] > 0 && matrix[row, j] % 2 == 0)
                {
                    sum += matrix[row, j];
                }
            }
            return sum;
        }

        private void SortMatrixByCharacteristics(int[,] matrix, int rows, int cols)
        {
            int[] characteristics = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                characteristics[i] = CalculateRowCharacteristic(matrix, i, cols);
            }

            // Сортировка строк матрицы по характеристикам
            for (int i = 0; i < rows - 1; i++)
            {
                for (int k = i + 1; k < rows; k++)
                {
                    if (characteristics[i] > characteristics[k])
                    {
                        // Меняем строки местами
                        for (int j = 0; j < cols; j++)
                        {
                            int temp = matrix[i, j];
                            matrix[i, j] = matrix[k, j];
                            matrix[k, j] = temp;
                        }
                        // Меняем характеристики местами
                        int tempChar = characteristics[i];
                        characteristics[i] = characteristics[k];
                        characteristics[k] = tempChar;
                    }
                }
            }
        }

        private string MatrixToString(int[,] matrix, int rows, int cols)
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += matrix[i, j] + " ";
                }
                result += Environment.NewLine;
            }
            return result;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем количество строк и столбцов из TextBox
                int rows = int.Parse(y.Text); // y - это TextBox для ввода количества строк
                int cols = int.Parse(x.Text); // x - это TextBox для ввода количества столбцов

                // Чтение матрицы из текстового поля
                int[,] matrix = ParseMatrix(inputMatrix.Text, rows, cols);

                // Подсчет столбцов без нулей
                int zeroFreeColumns = CountZeroFreeColumns(matrix, rows, cols);
                txtZeroFreeColumns.Text = zeroFreeColumns.ToString();
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
                // Получаем количество строк и столбцов из TextBox
                int rows = int.Parse(y.Text); // y - это TextBox для ввода количества строк
                int cols = int.Parse(x.Text); // x - это TextBox для ввода количества столбцов

                // Чтение матрицы из текстового поля
                int[,] matrix = ParseMatrix(inputMatrix.Text, rows, cols);

                // Сортировка матрицы по характеристикам
                SortMatrixByCharacteristics(matrix, rows, cols);

                // Вывод упорядоченной матрицы
                txtSortedMatrix.Text = MatrixToString(matrix, rows, cols);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}