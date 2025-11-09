// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task5.V5
// Description: Генерация массива и вычисление суммы положительных элементов (Вариант 5)

using System;
using Tyuiu.AxyonovMA.Sprint4.Task5.V5.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task5.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Двумерные массивы (генератор случайных чисел) | Задание #5 | Вариант #5 *");
            Console.WriteLine("***************************************************************************");

            Random rnd = new Random();
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Сгенерированный массив 5×5 (значения от –4 до 3):");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-4, 4); // верхняя граница 4 не включается
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }

            Class1 obj = new Class1();
            int result = obj.Calculate(matrix);

            Console.WriteLine($"\nСумма положительных элементов = {result}");
            Console.ReadKey();
        }
    }
}
