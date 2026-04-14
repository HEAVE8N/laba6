using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите C: ");
            int c = int.Parse(Console.ReadLine());

            MyNumbers obj = new MyNumbers(a, b, c);
            Console.WriteLine(obj.ToString());
            Console.WriteLine("Max digit: " + obj.MaxLastDigit());

            MyNumbers copy = new MyNumbers(obj);
            Console.WriteLine("Copy: " + copy.ToString());

            Console.Write("Длина: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Ширина: ");
            int w = int.Parse(Console.ReadLine());
            Console.Write("Высота: ");
            int h = int.Parse(Console.ReadLine());

            Box box = new Box(l, w, h);
            Console.WriteLine(box.ToString());
            Console.WriteLine("Cube: " + box.IsCube());

            Console.ReadLine();
        }
    }
}
