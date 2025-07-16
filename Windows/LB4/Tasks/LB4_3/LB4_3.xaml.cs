using System;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace TP.Windows.LB4.Tasks.LB4_3
{
    public partial class lb4_3 : Window
    {
        public lb4_3()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            if (rbDefault.IsChecked == true)
            {
                ProcessDefaultTest();
            }
            else
            {
                LoadCustomFile();
            }
        }

        private void ProcessDefaultTest()
        {
            // 5 тестовых примеров
            string[] testCases = {
                "3\n15 25 35",       
                "4\n24 36 48 60",    
                "5\n17 34 51 68 85", 
                "6\n14 21 28 35 42 49", 
                "3\n100 250 375"     
            };

            string[] lines = testCases[new Random().Next(0, 5)].Split('\n');
            ProcessInput(lines[0], lines[1]);
        }

        private void LoadCustomFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData1")
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    if (lines.Length >= 2)
                    {
                        ProcessInput(lines[0], lines[1]);
                    }
                    else if (lines.Length == 1)
                    {
                        // Если файл содержит только числа без m в первой строке
                        int m = lines[0].Split(' ').Length;
                        ProcessInput(m.ToString(), lines[0]);
                    }
                    else
                    {
                        MessageBox.Show("Файл должен содержать хотя бы одну строку с числами");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
                }
            }
        }

        private void ProcessInput(string mLine, string numbersLine)
        {
            try
            {
                // Парсинг количества чисел
                if (!int.TryParse(mLine.Trim(), out int m) || m < 2)
                {
                    MessageBox.Show("Первая строка должна содержать натуральное число m > 2");
                    return;
                }

                // Парсинг последовательности чисел
                int[] numbers = numbersLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (numbers.Length != m)
                {
                    MessageBox.Show($"Ожидалось {m} чисел, но получено {numbers.Length}");
                    return;
                }

                // Вычисляем НОД
                int gcd = CalculateGCD(numbers);

                // Формируем результат
                InputText.Text = $"Исходные числа (m = {m}):\n{string.Join(" ", numbers)}";
                ResultText.Text = $"НОД всех чисел: {gcd}";

                // Дополнительно показываем процесс вычисления
                ShowGCDSteps(numbers);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка формата чисел. Убедитесь, что ввод содержит только натуральные числа");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}");
            }
        }

        // Вычисление НОД для массива чисел
        private int CalculateGCD(int[] numbers)
        {
            int currentGCD = GCD(numbers[0], numbers[1]);

            for (int i = 2; i < numbers.Length; i++)
            {
                currentGCD = GCD(currentGCD, numbers[i]);
                if (currentGCD == 1) break; // Оптимизация - НОД не может стать меньше 1
            }

            return currentGCD;
        }

        // Алгоритм Евклида для двух чисел
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Показывает шаги вычисления НОД
        private void ShowGCDSteps(int[] numbers)
        {
            string steps = "\n\nШаги вычисления:\n";
            int currentGCD = numbers[0];

            steps += $"Начальное значение: {currentGCD}\n";

            for (int i = 1; i < numbers.Length; i++)
            {
                int prevGCD = currentGCD;
                currentGCD = GCD(prevGCD, numbers[i]);
                steps += $"НОД({prevGCD}, {numbers[i]}) = {currentGCD}\n";
            }

            StepsText.Text = steps;
        }

        private void CreateTestData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData1");
                Directory.CreateDirectory(dirPath);

                // Создаем 5 тестовых файлов
                File.WriteAllText(Path.Combine(dirPath, "test1.txt"), "3\n15 25 35");
                File.WriteAllText(Path.Combine(dirPath, "test2.txt"), "4\n24 36 48 60");
                File.WriteAllText(Path.Combine(dirPath, "test3.txt"), "5\n17 34 51 68 85");
                File.WriteAllText(Path.Combine(dirPath, "test4.txt"), "6\n14 21 28 35 42 49");
                File.WriteAllText(Path.Combine(dirPath, "test5.txt"), "3\n100 250 375");

                MessageBox.Show("Тестовые файлы успешно созданы в папке TestData1");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания тестовых файлов: {ex.Message}");
            }
        }
    }
}