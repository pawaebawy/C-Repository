using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace WhereIsMyMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance;
            balance = 0;
            string name;
            double money;
            char next;
            string line;
            string path = @"F:\GitHub\CRep\C-Repository\CSharp\WhereIsMyMoney\report";

            try
            {
                //проверяем, существует ли директория "path"
                if (!Directory.Exists(path))
                {
                    // если нет, то создаем ее.
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

           /* try
            {
                StreamReader sr = new StreamReader(path + @"\report.txt", System.Text.Encoding.Default);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }*/

            if (balance == 0)
            {
                Console.Write("Введите текущий баланс: ");
                balance = Convert.ToDouble(Console.ReadLine());
            }

            do
            {
                Console.Write("Затрата или прибыль? z or p ");
                name = Convert.ToString(Console.ReadLine());

                if (name == "z")
                {
                    Console.Write("Напишите название затраты: ");
                    name = Convert.ToString(Console.ReadLine());

                    Console.Write("Сколько денег вы потратили: ");
                    money = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        using (StreamWriter sw = new StreamWriter(path + @"\report.txt", true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"Название: {name}. Сумма: -{money}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка: " + ex.Message);
                    }

                    balance = balance - money;
                }
                else if (name == "p")
                {
                    Console.Write("Напишите название прибыли: ");
                    name = Convert.ToString(Console.ReadLine());

                    Console.Write("Сколько денег вы получили: ");
                    money = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        using (StreamWriter sw = new StreamWriter(path + @"\report.txt", true, System.Text.Encoding.Default))
                        {
                            sw.WriteLine($"Название: {name}. Сумма: +{money}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка: " + ex.Message);
                    }

                    balance = balance + money;
                }

                Console.WriteLine($"Текущий баланс: {balance}");
                Console.WriteLine("Были ли еще затраты или прибыли? y or n ");
                next = Convert.ToChar(Console.ReadLine());

                try
                {
                    using (StreamWriter sw = new StreamWriter(path + @"\report.txt", true, System.Text.Encoding.Default))
                    { 
                        sw.WriteLine($"Баланс: {balance}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }

            }
            while (next == 'y');

            Console.ReadLine();

        }
    }
}
