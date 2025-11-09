// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task7.V20
// Description: Преобразование строки в матрицу и вычисление произведения чётных чисел (Вариант 20)

using System;
using Tyuiu.AxyonovMA.Sprint4.Task7.V20.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task7.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Строки и матрицы | Задание #7 | Вариант #20               *");
            Console.WriteLine("***************************************************************************");

            string data = "357951248632587";
            int n = 5, m = 3;

            Console.WriteLine($"Исходная строка: {data}");

            Class1 obj = new Class1();
            int result = obj.Calculate(n, m, data);

            Console.WriteLine("\nМатрица 5×3:");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{data[index]} ");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nПроизведение чётных чисел = {result}");
            // Ожидаемо: 768

            Console.ReadKey();
        }
    }
}
