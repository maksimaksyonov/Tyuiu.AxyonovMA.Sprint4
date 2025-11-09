// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task4.V5
// Description: Сумма чётных элементов двумерного массива, вводимого с клавиатуры.

using System;
using Tyuiu.AxyonovMA.Sprint4.Task4.V5.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Двумерные массивы (ввод с клавиатуры) | Задание #4 | Вариант #5 *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];
            Console.WriteLine("Введите элементы массива 5x5 (значения от 3 до 9):");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"[{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nВведённая матрица:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
            }

            Class1 obj = new Class1();
            int result = obj.Calculate(matrix);

            Console.WriteLine($"\nСумма чётных элементов = {result}");
            Console.ReadKey();
        }
    }
}
