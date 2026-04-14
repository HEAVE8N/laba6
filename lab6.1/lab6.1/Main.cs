using System;

namespace Lab1
{
    public class MyNumbers
    {
        private int _a;
        private int _b;
        private int _c;

        public int A
        {
            get { return _a; }
        }

        public int B
        {
            get { return _b; }
        }

        public int C
        {
            get { return _c; }
        }

        public MyNumbers(int a, int b, int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public MyNumbers(MyNumbers other)
        {
            if (other != null)
            {
                _a = other._a;
                _b = other._b;
                _c = other._c;
            }
        }

        public int MaxLastDigit()
        {
            int lastA = Math.Abs(_a) % 10;
            int lastB = Math.Abs(_b) % 10;
            int lastC = Math.Abs(_c) % 10;

            int max = lastA;

            if (lastB > max)
            {
                max = lastB;
            }

            if (lastC > max)
            {
                max = lastC;
            }

            return max;
        }

        public override string ToString()
        {
            return "Поля: " + _a + ", " + _b + ", " + _c;
        }
    }
}
