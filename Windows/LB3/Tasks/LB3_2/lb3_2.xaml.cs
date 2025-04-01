using System;
using System.IO;
using System.Text;
using System.Windows;
using Microsoft.Win32;


namespace TP.Windows.LB3.Tasks.LB3_2


{
    /// <summary>
    /// Логика взаимодействия для lb3_2.xaml
    /// </summary>
    public partial class lb3_2 : Window
    {


        public lb3_2()
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

        
        private void FixButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст
            string text = InputText.Text;

            // Добавляем пробелы после запятых
            StringBuilder correctedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                correctedText.Append(text[i]);
                if (text[i] == ',' && (i + 1 >= text.Length || text[i + 1] != ' '))
                {
                    correctedText.Append(' ');
                }
            }

            // Выводим исправленный текст
            OutputText.Text = correctedText.ToString();
        }
    }
}