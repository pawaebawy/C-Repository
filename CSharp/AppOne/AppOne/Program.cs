using System;

namespace AppOne
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;
            char operation;

            Console.WriteLine("Введите первое число");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действие");
            operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            b = Convert.ToDouble(Console.ReadLine());

            if (operation == '+')
            {
                result = a + b;
                Console.WriteLine($"Сумма {a} и {b} равна {result}");
            }
            else if (operation == '-')
            {
                result = a - b;
                Console.WriteLine($"Вычитание {a} и {b} равно {result}");
            }
            else if (operation == '/')
            {
                result = a / b;
                Console.WriteLine($"Деление {a} на {b} равно {result}");
            }
            else if (operation == '*')
            {
                result = a * b;
                Console.WriteLine($"Умножение {a} на {b} равно {result}");
            }
            else
            {
                Console.WriteLine("Неизвестный оператор");
            }
            Console.ReadKey();
        }
    }
}
