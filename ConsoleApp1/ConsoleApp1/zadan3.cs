using System;

namespace Lab6
{
    public class Zadan3 : Zadan2
    {
        public Zadan3(double x, double y) : base(x, y) { }

        public static double operator !(Zadan3 s)
        {
            double res = s.Y - s.X;
            if (res < 0) res = -res;
            return res;
        }

        public static Zadan3 operator ++(Zadan3 s)
        {
            s.X = s.X + 1;
            s.Y = s.Y + 1;
            return s;
        }

        public static explicit operator int(Zadan3 s)
        {
            return (int)s.X;
        }

        public static implicit operator double(Zadan3 s)
        {
            return s.Y;
        }

        public static Zadan3 operator +(Zadan3 s, int d)
        {
            return new Zadan3(s.X + d, s.Y + d);
        }

        public static Zadan3 operator +(int d, Zadan3 s)
        {
            return s + d;
        }

        public static bool operator <(Zadan3 s, int n)
        {
            return s.Contains(n);
        }

        public static bool operator >(Zadan3 s, int n)
        {
            return !s.Contains(n);
        }
    }
}
