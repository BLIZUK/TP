using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace TP.Windows.LB1
{
    public partial class Lb1 : Window
    {
        public Lb1()
        {
            InitializeComponent();
        }

        // Функция для вычисления факториала
        private double Factorial(int n)
        {
            if (n < 0) throw new ArgumentException("Факториал определен только для неотрицательных чисел.");
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Функция для вычисления суммы ряда
        private double CalculateSeries(double x, double epsilon = 1e-10)
        {
            double sum = 0;
            int k = 1;

            while (true)
            {
                double coefficient = 2 * k + 1;
                double factorial = Factorial(k);
                double xPower = Math.Pow(x, 2 * k + 1);
                double term = (coefficient / factorial) * xPower;

                // Если текущий член ряда меньше epsilon, завершаем цикл
                if (Math.Abs(term) < epsilon)
                    break;

                sum += term;
                k++;
            }

            return sum;
        }

        // Функция для вычисления контрольного значения
        private double ControlFunction(double x)
        {
            return (x + 2 * Math.Pow(x, 3)) * Math.Exp(Math.Pow(x, 2)) - x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TextBox_x.Text, out double z))
            {
                double z1 = Math.Cos(z) + Math.Sin(z) + Math.Cos(3 * z) + Math.Sin(3 * z);
                TextBox_Z1.Text = z1.ToString("F6");

                double z2 = 2 * Math.Sqrt(2) * Math.Cos(z) * Math.Sin((Math.PI / 4) + 2 * z);
                TextBox_Z2.Text = z2.ToString("F6");

                StringBuilder result = new StringBuilder();
                double epsilon = 1e-10; // Точность

                // Внешний цикл: изменение X от 0.5 до 0.75 с шагом 0.05
                for (double x = 0.5; x <= 0.75; x += 0.05)
                {
                    double seriesSum = CalculateSeries(x, epsilon);
                    double controlValue = ControlFunction(x);

                    // Вывод результатов
                    result.AppendLine($"X = {x:F2}");
                    result.AppendLine($"Сумма ряда: {seriesSum:F10}");
                    result.AppendLine($"Контрольное значение: {controlValue:F10}");
                    result.AppendLine();
                }

                // Вывод всех результатов в текстовое поле или MessageBox
                MessageBox.Show(result.ToString(), "Результаты вычислений");
            }
            else
            {
                MessageBox.Show("Введите корректное число!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}