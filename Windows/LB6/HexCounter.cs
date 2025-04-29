using System;

namespace TP.Windows.LB6
{
    public class HexCounter
    {
        protected int _current;
        protected int _min;
        protected int _max;

        public HexCounter()
        {
            _min = 0x0;
            _max = 0xFF;
            _current = _min;
        }

        public HexCounter(int min, int max, int initial)
        {
            if (min >= max) throw new ArgumentException("Min must be less than max");
            if (initial < min || initial > max) throw new ArgumentOutOfRangeException();

            _min = min;
            _max = max;
            _current = initial;
        }

        public string CurrentState => $"0x{_current:X}";
        public int Min => _min;
        public int Max => _max;

        public virtual void Increment()
        {
            if (_current + 1 > _max)
                throw new InvalidOperationException("Counter overflow");
            _current++;
        }

        public virtual void Decrement()
        {
            if (_current - 1 < _min)
                throw new InvalidOperationException("Counter underflow");
            _current--;
        }

        // Добавлены методы для изменения границ
        public void SetMin(int newMin)
        {
            if (newMin >= _max) throw new ArgumentException("Новый min должен быть меньше max");
            _min = newMin;
            if (_current < _min) _current = _min;
        }

        public void SetMax(int newMax)
        {
            if (newMax <= _min) throw new ArgumentException("Новый max должен быть больше min");
            _max = newMax;
            if (_current > _max) _current = _max;
        }

    }

    public class AdvancedHexCounter : HexCounter
    {
        public AdvancedHexCounter(int min, int max, int initial) : base(min, max, initial) { }

        public void IncrementBy(int n)
        {
            if (n < 0) throw new ArgumentException("Value must be positive");
            if (_current + n > _max)
                throw new InvalidOperationException("Counter overflow");
            _current += n;
        }

        public void DecrementBy(int n)
        {
            if (n < 0) throw new ArgumentException("Value must be positive");
            if (_current - n < _min)
                throw new InvalidOperationException("Counter underflow");
            _current -= n;
        }
    }
}