using System;

namespace exercise1
{
    class Program
    {

        static void formula(double i, double a, double b)
        {
            double y = Math.Log10(Math.Pow(i, 2) - 1) / Math.Log(a * Math.Pow(i, 2) - b, 5);
            Console.WriteLine($"Для x = {i}, y = {Math.Round(y, 4)}");
        }

        static void Main(string[] args)
        {
            double a = 1.1;
            double b = 0.09;
            Console.WriteLine("9 вариант");
            Console.WriteLine();
            Console.WriteLine("Задание 1");
            for (double i = 1.2; i <= 2.2; i = i + 0.2)
            {
                formula(i, a, b);
            }

            Console.WriteLine();
            Console.WriteLine("Задание 2");

            double[] mass = new double[5] { 1.21, 1.76, 2.53, 3.48, 4.52 };
            for (int i = 0; i < mass.Length; i++)
            {
                formula(mass[i], a, b);
            }

            Console.ReadKey();
        }
    }
}