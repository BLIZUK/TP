using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace TP.Windows.LB5.Tasks.LB5_1
{
    public partial class LB5_1 : Window
    {
        private const string FilePath = "sequence.txt";

        public LB5_1()
        {
            InitializeComponent();
        }

        private void GenerateAndSave_Click(object sender, RoutedEventArgs e)
        {
            List<double> numbers = new List<double>();

            for (int i = 1; i <= 15; i++)
            {
                double y;
                if (i < 8)
                    y = Math.Sin(i * Math.PI / 8);
                else if (i > 8)
                    y = 4 * Math.Cos(i * (Math.PI + 1) / 5);
                else
                    y = 0; // можно определить по-другому, если нужно

                numbers.Add(y);
            }

            File.WriteAllLines(FilePath, numbers.Select(n => n.ToString("F4")));

            MessageBox.Show("Файл успешно создан и записан.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ReadAndDisplay_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(FilePath))
            {
                MessageBox.Show("Файл не найден. Сначала сгенерируйте данные.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string[] lines = File.ReadAllLines(FilePath);
            OutputListBox.Items.Clear();

            int negativeCount = 0;

            foreach (string line in lines)
            {
                if (double.TryParse(line, out double value))
                {
                    OutputListBox.Items.Add(value.ToString("F4"));
                    if (value < 0) negativeCount++;
                }
            }

            NegativeCountText.Text = $"Количество отрицательных чисел: {negativeCount}";
        }
    }
}
