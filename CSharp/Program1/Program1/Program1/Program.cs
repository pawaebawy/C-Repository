using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;
            double a = 1.1;
            double b = 0.09;
            for (double i = 1.2; i <= 2.2; i = i + 0.2)
            {
                y = (Math.Log((Math.Pow(i,2))-1)) / (Math.Log10(a*Math.Pow(i,2)-b) / Math.Log10(5));
                Console.WriteLine($"Для шага {i} функция y = {Math.Round(y, 4)}");
            }

            Console.ReadKey();
        }
    }
}
