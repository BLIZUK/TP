using System;
using System.Windows;

namespace TP.Windows.LB6
{
    public partial class Lb6 : Window
    {
        private HexCounter _counter;
        private bool _useAdvanced;

        public Lb6()
        {
            InitializeComponent();
            InitializeCounter();
        }

        private void InitializeCounter()
        {
            try
            {
                int min = ParseHex(min_TB.Text);
                int max = ParseHex(max_TB.Text);
                int initial = (min + max) / 2;

                _counter = new AdvancedHexCounter(min, max, initial);
                _useAdvanced = true;
                UpdateDisplay();
            }
            catch
            {
                _counter = new HexCounter();
                _useAdvanced = false;
                min_TB.Text = "0x0";
                max_TB.Text = "0xFF";
                UpdateDisplay();
            }
        }

        private int ParseHex(string input)
        {
            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                return Convert.ToInt32(input, 16);
            return int.Parse(input);
        }

        private void UpdateDisplay()
        {
            info_TB.Text = _counter.CurrentState;
            min_TB.Text = $"0x{_counter.Min:X}";
            max_TB.Text = $"0x{_counter.Max:X}";
        }

        private void Dev_but_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int step = ParseHex(count_TB.Text);

                if (_useAdvanced && _counter is AdvancedHexCounter adv)
                {
                    adv.DecrementBy(step);
                }
                else
                {
                    for (int i = 0; i < step; i++)
                        _counter.Decrement();
                }

                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Min_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                int newMin = ParseHex(min_TB.Text);
                _counter.SetMin(newMin);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка изменения min: {ex.Message}");
                min_TB.Text = $"0x{_counter.Min:X}";
            }
        }

        private void ApplyBounds_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int newMin = ParseHex(min_TB.Text);
                int newMax = ParseHex(max_TB.Text);

                _counter.SetMin(newMin);
                _counter.SetMax(newMax);

                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                min_TB.Text = $"0x{_counter.Min:X}";
                max_TB.Text = $"0x{_counter.Max:X}";
            }
        }

        private void Max_TB_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                int newMax = ParseHex(max_TB.Text);
                _counter.SetMax(newMax);
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка изменения max: {ex.Message}");
                max_TB.Text = $"0x{_counter.Max:X}";
            }
        }

        private void Add_but_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int step = ParseHex(count_TB.Text);

                if (_useAdvanced && _counter is AdvancedHexCounter adv)
                {
                    adv.IncrementBy(step);
                }
                else
                {
                    for (int i = 0; i < step; i++)
                        _counter.Increment();
                }

                UpdateDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}