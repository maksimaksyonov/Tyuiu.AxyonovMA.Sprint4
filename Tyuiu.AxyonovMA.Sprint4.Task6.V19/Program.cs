// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task6.V19
// Description: Подсчёт количества строк длиной > 5 в строковом массиве

using System;
using Tyuiu.AxyonovMA.Sprint4.Task6.V19.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task6.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Строковые массивы | Задание #6 | Вариант #19               *");
            Console.WriteLine("***************************************************************************");

            string[] browsers = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };

            Console.WriteLine("Исходный массив строк:");
            foreach (string b in browsers)
            {
                Console.WriteLine("- " + b);
            }

            Class1 obj = new Class1();
            int result = obj.Calculate(browsers);

            Console.WriteLine($"\nКоличество элементов, длина которых больше 5: {result}");
            // Ожидаемый результат: 4

            Console.ReadKey();
        }
    }
}
