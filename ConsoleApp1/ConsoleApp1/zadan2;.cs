using System;

namespace Lab6
{
    public class Zadan2
    {
        private double _x;
        private double _y;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Zadan2() : this(0, 0) { }

        public Zadan2(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public bool Contains(double n)
        {
            double min = _x;
            double max = _y;

            if (_x > _y)
            {
                min = _y;
                max = _x;
            }
            return n >= min && n <= max;
        }

        public override string ToString()
        {
            return "[" + _x + "; " + _y + "]";
        }
    }
}
