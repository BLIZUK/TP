using System;


namespace TP.Windows.LB6;


// Базовый класс счетчика
public class HexCounter
{
    protected int _current;
    protected readonly int _min;
    protected readonly int _max;

    // Конструктор
    public HexCounter()
    {
        _min = 0x0;
        _max = 0xFF; // 255
        _current = _min;
    }

    // Перегрузка: Конструктор с произвольными значениями
    public HexCounter(int min, int max, int initial)
    {
        if (min >= max) throw new ArgumentException("Ошибка: min>max");
        if (initial < min || initial > max) throw new ArgumentOutOfRangeException();

        _min = min;
        _max = max;
        _current = initial;
    }

    // Текущее состояние (шестнадцатеричное представление)
    public string CurrentState => $"0x{_current:X}";

    public int min()
    {
        return _min;
    }

    public int max()
    {
        return _max;
    }


    // Увеличение на 1
    public void Increment()
    {
        if (_current + 1 > _max)
            throw new InvalidOperationException("Ошибка: Выход за границу");

        _current++;
    }

    // Уменьшение на 1
    public void Decrement()
    {
        if (_current - 1 < _min)
            throw new InvalidOperationException("Ошибка: Выход за границу");

        _current--;
    }
}


// Дочерний класс с расширенным функционалом
public class AdvancedHexCounter(int min, int max, int initial) : HexCounter(min, max, initial)
{

    // Увеличение на N
    public void IncrementBy(int n)
    {
        if (n < 0) throw new ArgumentException("Ошибка:значение должно быть положительными");
        if ((int)_current + n > _max)
            throw new InvalidOperationException("Ошибка: Выход за границу");

        _current += n;
    }

    // Уменьшение на N
    public void DecrementBy(int n)
    {
        if (n < 0) throw new ArgumentException("Ошибка:значение должно быть положительными");
        if ((int)_current - n < _min)
            throw new InvalidOperationException("Ошибка: Выход за границу");

        _current -= n;
    }
}