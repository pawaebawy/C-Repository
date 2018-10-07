using System;

namespace AppOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
            Console.ReadKey();
        }
    }
}
