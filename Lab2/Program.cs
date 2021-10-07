using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = double.Parse(Console.ReadLine());
            double a = Math.Sqrt(Math.Abs(x)) + Math.Exp(Math.Sqrt(b));
            Console.WriteLine("a={0:F2}", a);
            double c = Math.Log(a) + Math.Pow(b, 2);
            Console.WriteLine("c={0:F2}", c);
            double y = Math.Pow(a, 3) / Math.Cos(c);
            Console.WriteLine("y={0:F2}", y);
        }
    }
}
