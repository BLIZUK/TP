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
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Изучение классов языка программирования C# для работы со строками:");
            TextInfo.Items.Add($"\t1.Работа с функциями класса System.String");
            TextInfo.Items.Add($"\t2.Работа с функциями класса System.Text.StringBuilder");
            TextInfo.Items.Add($"\t3.Работа с регулярными выражениями. Поиск в тексте фрагментов по");
            TextInfo.Items.Add($"\t  определенному шаблону");
            TextInfo.Items.Add($"  Вариант 2:");
            TextInfo.Items.Add($"\t1.Написать программу, которая вводит текст, состоящий из нескольких ");
            TextInfo.Items.Add($"\t  предложений, и выводит на экран только предложения, содержащие ");
            TextInfo.Items.Add($"\t  введенное с клавиатуры слово.   ");
            TextInfo.Items.Add($"\t2.По правилам машинописи после запятой в тексте все¬гда ставится пробел.");
            TextInfo.Items.Add($"\t  Составить программу исправления такого типа ошибок в тексте.");
            TextInfo.Items.Add($"\t3.Дан текстовый файл. Вывести все слова, начинающиеся с согласных");
            TextInfo.Items.Add($"\t  букв русского алфавита.");
        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb4_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 4;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 4:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Изучение методов тестирования программного обеспечения:");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");


        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb5_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 5;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 5:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  Рассмотреть возможности С# для работы с потоками байтов символов и строк.");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"Вариант 2:");
            TextInfo.Items.Add($"        1.Сформировать файл последовательности 20 чисел, в кото¬рой каждый i-й");
            TextInfo.Items.Add($"          определяется по формуле");
            TextInfo.Items.Add($"          y=sin(i*π / 8), если i < 8;");
            TextInfo.Items.Add($"          y=4cos(i(π +1)/5), i > 8.");
            TextInfo.Items.Add($"          Определить количество отрицательных значений, содержащихся в сформированном");
            TextInfo.Items.Add($"        2.Подсчитать количество сдвоенных символов 'ее', 'нн', 'лл' в тексте,");
            TextInfo.Items.Add($"          в текстовом файле.");
            TextInfo.Items.Add($"");
            TextInfo.Items.Add($"");
        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb6_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 6;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 6:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"  1. Создать класс. Каждый разрабатываемый класс должен, как правило, содержать   ");
            TextInfo.Items.Add($"  элементы: a. скрытые поля; b. конструкторы с параметрами и без параметров,");
            TextInfo.Items.Add($"  методы, свойства. Методы и свойства должны обеспечивать непротиворечивый, ");
            TextInfo.Items.Add($"  минимальный и удобный интерфейс класса. d. при возникновении ошибок должны ");
            TextInfo.Items.Add($"  исключения. e. В программе должна выполняться проверка всех разработанных класса. ");
            TextInfo.Items.Add($"Вариант 2:  ");
            TextInfo.Items.Add($"  Описать класс, реализующий шестнадцатеричный счетчик, который может увеличивать ");
            TextInfo.Items.Add($"  уменьшать свое значение на единицу в заданном диапазоне. Предусмотреть ");
            TextInfo.Items.Add($"  счетчика значениями по умолчанию и произвольными значениями. Счетчик ");
            TextInfo.Items.Add($"  два метода: увеличения и уменьшения, — и свойство, позволяющее получить ");
            TextInfo.Items.Add($"  текущее состояние. При выходе за границы диапазо¬на выбрасываются исключения. ");
            TextInfo.Items.Add($"  программу, демонстрирующую все разработанные элементы класса. Создать ");
            TextInfo.Items.Add($"  класс, который может увеличивать или уменьшать свое значение на любое ");
            TextInfo.Items.Add($"  число в заданном диапазоне ");
            TextInfo.Items.Add($"   ");
        }


        //кнопка ---------------------------------------------------------------------------------------
        private void Lb7_Click(object sender, RoutedEventArgs e)
        {
            flagChoseLb = 7;
            TextInfo.Items.Clear();
            TextInfo.Items.Add($" ");
            TextInfo.Items.Add($"\t\t\t    Лабораторная работа 7:");
            TextInfo.Items.Add($"Цель работы:");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
            TextInfo.Items.Add($"   ");
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
                      
                case 5:
                    TP.Windows.LB5.Lb5 lb5win = new()
                    {
                        Owner = this
                    };
                    lb5win.Show();
                    break;
                    
                case 6:
                    TP.Windows.LB6.Lb6 lb6win = new()
                    {
                        Owner = this
                    };
                    lb6win.Show();
                    break;
                    /*
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