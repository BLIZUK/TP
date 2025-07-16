using System;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace TP.Windows.LB4.Tasks.LB4_2
{
    public partial class lb4_2 : Window
    {
        public lb4_2()
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
            // Тестовые данные (5 вариантов)
            string[] testCases = {
                "5\n5 3 4 1 2",
                "6\n1 4 2 5 3 6",
                "8\n10 9 2 5 3 7 101 1",
                "7\n0 8 4 12 2 10 6",
                "5\n7 7 7 7 7"
            };

            string[] lines = testCases[new Random().Next(0, 5)].Split('\n');
            ProcessInput(lines[0], lines[1]);
        }

        private void LoadCustomFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt",
                InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData")
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
                        // Если файл содержит только числа без N в первой строке
                        ProcessInput(lines[0].Split(' ').Length.ToString(), lines[0]);
                    }
                    else
                    {
                        MessageBox.Show("Файл должен содержать последовательность чисел");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка чтения файла: {ex.Message}");
                }
            }
        }

        private void ProcessInput(string nLine, string numbersLine)
        {
            try
            {
                // Парсинг количества чисел
                if (!int.TryParse(nLine.Trim(), out int n) || n <= 0)
                {
                    MessageBox.Show("Первая строка должна содержать натуральное число N");
                    return;
                }

                // Парсинг последовательности чисел
                int[] numbers = numbersLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (numbers.Length != n)
                {
                    MessageBox.Show($"Ожидалось {n} чисел, но получено {numbers.Length}");
                    return;
                }

                // Находим наибольшую возрастающую подпоследовательность
                var (lis, indices) = FindLIS(numbers);
                int toRemove = n - lis.Length;

                // Формируем результат
                InputText.Text = $"Исходная последовательность ({n} чисел):\n{string.Join(" ", numbers)}";

                string markedSequence = "";
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (indices.Contains(i))
                        markedSequence += $"[{numbers[i]}] ";
                    else
                        markedSequence += $"{numbers[i]} ";
                }

                ResultText.Text = $"Отмеченная последовательность:\n{markedSequence}\n\n" +
                                $"Наибольшая возрастающая подпоследовательность ({lis.Length} чисел):\n{string.Join(" ", lis)}\n\n" +
                                $"Нужно удалить: {toRemove} элементов";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка формата чисел. Убедитесь, что ввод содержит только целые числа");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обработки: {ex.Message}");
            }
        }


        private (int[] sequence, int[] indices) FindLIS(int[] nums)
        {
            if (nums.Length == 0) return (new int[0], new int[0]);

            int[] tails = new int[nums.Length];
            int[] prevIndices = new int[nums.Length];
            int[] indices = new int[nums.Length];
            int len = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int left = 0, right = len;
                while (left < right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[tails[mid]] < nums[i])
                        left = mid + 1;
                    else
                        right = mid;
                }

                if (left > 0) prevIndices[i] = tails[left - 1];
                tails[left] = i;
                indices[left] = i;
                if (left == len) len++;
            }

            // Восстанавливаем последовательность
            int[] result = new int[len];
            int[] resultIndices = new int[len];
            for (int i = tails[len - 1], j = len - 1; j >= 0; j--)
            {
                result[j] = nums[i];
                resultIndices[j] = i;
                i = prevIndices[i];
            }

            return (result, resultIndices);
        }

        private void CreateTestData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData");
                Directory.CreateDirectory(dirPath);

                // Создаем 5 тестовых файлов
                File.WriteAllText(Path.Combine(dirPath, "test1.txt"), "5\n5 3 4 1 2");
                File.WriteAllText(Path.Combine(dirPath, "test2.txt"), "6\n1 4 2 5 3 6");
                File.WriteAllText(Path.Combine(dirPath, "test3.txt"), "8\n10 9 2 5 3 7 101 1");
                File.WriteAllText(Path.Combine(dirPath, "test4.txt"), "7\n0 8 4 12 2 10 6");
                File.WriteAllText(Path.Combine(dirPath, "test5.txt"), "5\n7 7 7 7 7");

                MessageBox.Show("Тестовые файлы успешно созданы в папке TestData");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания тестовых файлов: {ex.Message}");
            }
        }
    }
}