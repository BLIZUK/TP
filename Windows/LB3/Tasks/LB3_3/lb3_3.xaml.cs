using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using Microsoft.Win32;

namespace TP.Windows.LB3.Tasks.LB3_3
{
    public partial class lb3_3 : Window
    {
        public lb3_3()
        {
            InitializeComponent();
        }

        // Кнопка загрузки файла
        private void LoadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Выберите текстовый файл"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    string text = File.ReadAllText(openFileDialog.FileName);
                    FindConsonantWords(text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }

        // Поиск слов по регулярному выражению
        private void FindConsonantWords(string text)
        {
            ResultsListBox.Items.Clear();

            // Регулярное выражение для поиска слов, начинающихся с согласных
            string pattern = @"\b[бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ]\w*\b";

            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
                ResultsListBox.Items.Add(match.Value);
            }

            if (ResultsListBox.Items.Count == 0)
            {
                MessageBox.Show("Слова, начинающиеся с согласных букв, не найдены");
            }
        }
    }
}