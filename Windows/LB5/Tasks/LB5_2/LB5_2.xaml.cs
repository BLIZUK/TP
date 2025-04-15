using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace TP.Windows.LB5.Tasks.LB5_2
{
    public partial class LB5_2: Window
    {
        public LB5_2()
        {
            InitializeComponent();
        }

        private void SelectFileAndCount_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Выберите текстовый файл",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string content = File.ReadAllText(openFileDialog.FileName).ToLower();

                int countEE = CountOccurrences(content, "ее");
                int countNN = CountOccurrences(content, "нн");
                int countLL = CountOccurrences(content, "лл");

                ResultTextBlock.Text = $"Количество 'ее': {countEE}\n" +
                                       $"Количество 'нн': {countNN}\n" +
                                       $"Количество 'лл': {countLL}";
            }
        }

        private int CountOccurrences(string text, string pattern)
        {
            int count = 0;
            int index = 0;

            while ((index = text.IndexOf(pattern, index)) != -1)
            {
                count++;
                index += pattern.Length;
            }

            return count;
        }
    }
}
