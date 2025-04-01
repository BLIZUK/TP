using System;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;


namespace TP.Windows.LB3.Tasks.LB3_1


{
    /// <summary>
    /// Логика взаимодействия для lb3_1.xaml
    /// </summary>
    public partial class lb3_1 : Window
    {
        public lb3_1()
        {
            InitializeComponent();
        }
        private void LoadTextButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    // Чтение текста из файла
                    string fileText = File.ReadAllText(openFileDialog.FileName);
                    InputText.Text = fileText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
                }
            }
        }

        // Обработчик для кнопки "Найти предложения"
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст и слово для поиска
            string text = InputText.Text;
            string word = InputWord.Text;

            // Разделяем текст на предложения
            string[] sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Очищаем список результатов
            ResultListBox.Items.Clear();

            // Ищем предложения, содержащие слово
            foreach (var sentence in sentences)
            {
                if (sentence.Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    ResultListBox.Items.Add(sentence.Trim());
                }
            }
        }
    }
}