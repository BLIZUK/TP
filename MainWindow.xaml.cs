using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TP
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   

    public partial class MainWindow : Window
    {
        // Флаг выбора программы
        private int flagChoseLb = 0;

        public MainWindow()
        {
            InitializeComponent();
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"\t\t\tВыберите лабораторную задачу.");
            TextInfo.Items.Add(" ");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");

        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb1_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 1;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 1:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Изучение основ языка С# и знакомство с элементами управления C#.");
            TextInfo.Items.Add($"  Составление линейных и циклических программ. Работа с математическими функциями C#.");
            TextInfo.Items.Add(" ");
            TextInfo.Items.Add($"  Вариант 2:");
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($" ");

        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb2_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 2;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 2:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Изучить  особенности работы с массивами в языке C#, свойства и методы класса");
            TextInfo.Items.Add($"  System.Array класса System.Array. ");
            TextInfo.Items.Add($"Подготовка к работе: ");
            TextInfo.Items.Add($"     •  Изучить работу с одномерными и двумерными прямоугольными и ступенчатыми");
            TextInfo.Items.Add($"        массивами в среде C#.");
            TextInfo.Items.Add($"     •  Ознакомиться с методами класса System.Array.");
            TextInfo.Items.Add($"  Вариант 2:");
            TextInfo.Items.Add($"    1. В одномерном массиве, состоящем из п вещественных элементов, вычислить");
            TextInfo.Items.Add($"\t• Сумму положительных элементов массива;");
            TextInfo.Items.Add($"\t• Произведение элементов массива, расположенных между максимальным");
            TextInfo.Items.Add($"\t    по модулю и минимальным по модулю элементами.");
            TextInfo.Items.Add($"\t    Упорядочить элементы массива по убыванию.");
            TextInfo.Items.Add($"    2. Дана целочисленная прямоугольная матрица. Определить");
            TextInfo.Items.Add($"    количество столбцов, не содержащих ни одного нулевого элемента.");
            TextInfo.Items.Add($"    3. Построить классическую ступенчатую матрицу.");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");


        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb3_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 3;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 3:");
            TextInfo.Items.Add($"Цель работы:  Работа со строками");
        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb4_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 4;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 4:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Цель работы заключается в  освоении методов работы с файлами");
            TextInfo.Items.Add($"    проецируемыми в память. ");
            TextInfo.Items.Add($"  Задания для самостоятельной работы:");
            TextInfo.Items.Add($"    С помощью механизма проецирования в память  замените в текстовом файле все");
            TextInfo.Items.Add($"    строчные буквы на прописные и удвойте вхождение каждой цифры. ");


        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb5_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 5;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 5:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Целью работы является изучение основных принципов организации");
            TextInfo.Items.Add($"    многозадачных операционных систем. Все многозадачные операционные");
            TextInfo.Items.Add($"    системы используют концепцию процесса и потока.");
            TextInfo.Items.Add($"    В данной работе рассматриваются  следующие вопросы:");
            TextInfo.Items.Add($"\t•  Чередование выполнения нескольких процессов с целью повышения");
            TextInfo.Items.Add($"\t   степени использования процессора;");
            TextInfo.Items.Add($"\t•  Разделение ресурсов между процессами;");
            TextInfo.Items.Add($"\t•  Организация обмена данными между процессами и потоками;");
            TextInfo.Items.Add($"\t•  Изменение класса приоритета процесса и уровня приоритета потока.");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"Задание для выполнения:");
            TextInfo.Items.Add($"\t2. Программа, выполняющая запуск любого процесса и завершение");
            TextInfo.Items.Add($"\t   данного процесса по команде пользователя.");

        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb6_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 6;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 6:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Целью работы является получение навыков работы  с функциями ");
            TextInfo.Items.Add($"    библиотеки ToolHelp API для получения системной информации. В данной ");
            TextInfo.Items.Add($"    работе рассматриваются следующие вопросы:");
            TextInfo.Items.Add($"\t•  Получение списка всех  процессов в системе;");
            TextInfo.Items.Add($"\t•  Получение списка всех  модулей в системе;");
            TextInfo.Items.Add($"\t•  Получение списка всех  потоков выбранного процесса;");
            TextInfo.Items.Add($"\t•  Получение карты памяти выбранного процесса.");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"Задания для самостоятельной работы");
            TextInfo.Items.Add($"\t2. Программа, формирующая список всех процессов, выполняющихся");
            TextInfo.Items.Add($"\t   на данном компьютере и позволяющая просматривать  список");
            TextInfo.Items.Add($"\t   потоков данного процесса.");
        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb7_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 7;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 7:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Целью данной работы является  исследование объектов синхронизации,");
            TextInfo.Items.Add($"    с помощью которых в многозадачной среде обеспечивается ");
            TextInfo.Items.Add($"    последовательный доступ к совместно используемым ресурсам. В данной");
            TextInfo.Items.Add($"    работе рассматриваются следующие вопросы:");
            TextInfo.Items.Add($"\t•Синхронизация потоков с помощью объектов пользовательского режима");
            TextInfo.Items.Add($"\t (критические секции);");
            TextInfo.Items.Add($"\t•Синхронизация потоков с помощью объектов ядра (объекты Mutex, ");
            TextInfo.Items.Add($"\t события, семафоры, процессы и потоки);");
            TextInfo.Items.Add($"\t•Работа Wait- функций в различных режимах.");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"Задания для самостоятельной работы");
            TextInfo.Items.Add($"    2.Исследование возможности синхронизации потоков с помощью событий. ");
            TextInfo.Items.Add($"    Создание двух приложений. Первое приложение следит  за вторым ");
            TextInfo.Items.Add($"    приложением. Второе приложение позволяет пользователю вводить с ");
            TextInfo.Items.Add($"    помощью клавиатуры и отображать в своем окне произвольные символы.");
            TextInfo.Items.Add($"    Первое, контролирующее приложение при вводе  в окне второго приложения");
            TextInfo.Items.Add($"    символа отображает в своем окне символ \"*\".");
        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 0;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"\t\t\t\t       TP");
            TextInfo.Items.Add($"\t\t\t\t     0.0.3");
            TextInfo.Items.Add($"\t\t   Разработана Близученко Андреем ИВТ2-23");
            TextInfo.Items.Add($"\t\t\t\t 10.03.2025");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
        }


        //кнопка ---------------------------------------------------------------------------------------
        //Для запуска дополнительных окон 
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            switch (flagChoseLb)
            {
       
                case 0:
                    MessageBox.Show("Не выбрана лабораторная работа!");
                    break;

                case 1:
                    TP.Windows.LB1.Lb1 Lb1win = new()
                    {
                        Owner = this
                    };
                    Lb1win.Show();
                    break;

                case 2:
                    TP.Windows.LB2.Lb2 Lb2win = new()
                    {
                        Owner = this
                    };
                    Lb2win.Show();
                    break;

                case 3:
                    TP.Windows.LB3.Lb3 Lb3win = new()
                    {
                        Owner = this
                    };
                    Lb3win.Show();
                    break;

                case 4:
                    TP.Windows.LB4.Lb4 Lb4win = new()
                    {
                        Owner = this
                    };
                    Lb4win.Show();
                    break;
                    /*  
                case 5:
                    Lb5Window lb5win = new()
                    {
                        Owner = this
                    };
                    lb5win.Show();
                    break;

                case 6:
                    Lb6Window lb6win = new()
                    {
                        Owner = this
                    };
                    lb6win.Show();
                    break;
                case 7:

                    Lb7_1Window lb7 = new()
                    {
                        Owner = this
                    };
                    lb7win.Show();
                    break;
                */
            }
        }
    }
}