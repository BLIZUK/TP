using System;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace TP.Windows.LB4.Tasks.LB4_1
{
    public partial class lb4_1 : Window
    {
        private int currentTestNumber = 1;
        private const string TestFilesDir = "data";
        private const int MaxTests = 5; // Количество тестовых файлов

        public lb4_1()
        {
            InitializeComponent();
            CreateTestFilesIfNotExist(); // Создаем тестовые файлы при запуске
            LoadDefaultTestData(); // Загружаем первый тест автоматически
        }

        private void CreateTestFilesIfNotExist()
        {
            string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TestFilesDir);

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);

                // Создаем 5 тестовых файлов
                File.WriteAllText(Path.Combine(dirPath, "Test1.txt"), "5\n15.3 20.7 18.2 25.1 12.8");
                File.WriteAllText(Path.Combine(dirPath, "Test2.txt"), "6\n19.0 21.5 18.3 20.4 17.9 22.1");
                File.WriteAllText(Path.Combine(dirPath, "Test3.txt"), "4\n10.1 15.2 19.9 12.3");
                File.WriteAllText(Path.Combine(dirPath, "Test4.txt"), "3\n25.0 30.1 22.3");
                File.WriteAllText(Path.Combine(dirPath, "Test5.txt"), "7\n20.5 19.9 20.4 20.6 15.0 20.49 10.0");
            }
        }

        private void itog_Click(object sender, RoutedEventArgs e)
        {
            if (rbDefault.IsChecked == true)
            {
                LoadDefaultTestData();
            }
            else if (rbCustom.IsChecked == true)
            {
                LoadCustomFile();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (rbDefault.IsChecked == true)
            {
                currentTestNumber = 1; // Сброс на первый тест при переключении
                LoadDefaultTestData();
            }
        }

        private void LoadDefaultTestData()
        {
            try
            {
                string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TestFilesDir);
                string filePath = Path.Combine(dirPath, $"Test{currentTestNumber}.txt");

                if (File.Exists(filePath))
                {
                    ProcessFileContent(File.ReadAllText(filePath));
                    TB.Text = $"Тест {currentTestNumber} из {MaxTests}";

                    // Переход к следующему тесту (циклически)
                    currentTestNumber = currentTestNumber % MaxTests + 1;
                }
                else
                {
                    MessageBox.Show("Тестовые файлы не найдены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки тестовых данных: {ex.Message}");
            }
        }

        private void LoadCustomFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    ProcessFileContent(File.ReadAllText(openFileDialog.FileName));
                    TB.Text = "Пользовательский файл";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
                }
            }
        }

        private void ProcessFileContent(string content)
        {
            try
            {
                string[] lines = content.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                if (lines.Length < 1)
                    throw new Exception("Файл не содержит данных");

                // Первая строка - число N
                if (!int.TryParse(lines[0], out int n) || n <= 0)
                    throw new Exception("Неверный формат числа N");

                // Вторая строка - числа через пробел
                double[] numbers = lines[1].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                if (numbers.Length != n)
                    throw new Exception($"Ожидалось {n} чисел, получено {numbers.Length}");

                // Вычисление результата
                double sum = numbers.Where(x => x < 20.5).Sum();
                bool result = sum <= 50;

                // Вывод результатов
                txtInputData.Text = $"N = {n}\nЧисла: {string.Join(" ", numbers.Select(x => x.ToString("F2")))}";
                txtResult.Text = $"Сумма (Для чисел < 20.5): {sum:F2}\nРезультат: {(result ? "Не превышает" : "ПРЕВЫШАЕТ")} 50";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки данных: {ex.Message}");
            }
        }

        private void NextTest_Click(object sender, RoutedEventArgs e)
        {
            if (rbDefault.IsChecked == true)
            {
                LoadDefaultTestData();
            }
        }
    }
}