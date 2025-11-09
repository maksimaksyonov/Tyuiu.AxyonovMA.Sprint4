// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task3.V21
// Description: Консольное приложение. Произведение элементов последнего столбца.

using System;
using Tyuiu.AxyonovMA.Sprint4.Task3.V21.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Двумерные массивы (статический ввод) | Задание #3 | Вариант #21 *");
            Console.WriteLine("***************************************************************************");

            int[,] a =
            {
                { 8, 3, 3, 3, 5 },
                { 6, 7, 3, 3, 7 },
                { 4, 5, 4, 6, 6 },
                { 5, 5, 8, 8, 7 },
                { 4, 6, 6, 7, 7 }
            };

            // печать матрицы
            Console.WriteLine("Матрица 5x5:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write($"{a[i, j],3}");
                Console.WriteLine();
            }

            Class1 obj = new Class1();
            int product = obj.Calculate(a);

            Console.WriteLine($"\nПроизведение последнего столбца = {product}"); // ожидаемо: 10290
            Console.ReadKey();
        }
    }
}
