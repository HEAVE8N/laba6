using System;

namespace Lab6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите X: ");
            double.TryParse(Console.ReadLine(), out var x);

            Console.Write("Введите Y: ");
            double.TryParse(Console.ReadLine(), out var y);

            var s = new Zadan3(x, y);

            Console.WriteLine("Отрезок: " + s.ToString());
            Console.WriteLine("Длина: " + !s);

            s++;
            Console.WriteLine("После ++: " + s.ToString());

            int intX = (int)s;
            double dblY = s;
            Console.WriteLine("X(int): " + intX);
            Console.WriteLine("Y(double): " + dblY);

            s = s + 5;
            Console.WriteLine("Сдвиг +5: " + s.ToString());
            Console.WriteLine("Число 10 входит: " + (s < 10));

            Console.ReadKey();
        }
    }
}
