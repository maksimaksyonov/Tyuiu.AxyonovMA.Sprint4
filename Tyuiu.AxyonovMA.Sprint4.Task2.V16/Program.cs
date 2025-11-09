// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task2.V16
// Description: Генерация массива и подсчёт суммы нечётных элементов (Вариант 16)

using System;
using Tyuiu.AxyonovMA.Sprint4.Task2.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task2.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Одномерные массивы (генератор случайных чисел) | Задание #2 | Вариант #16 *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[10];
            Random rnd = new Random();

            Console.WriteLine("Исходный массив из 10 элементов (диапазон 2–9):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 10); // 10 не включается → 2..9
                Console.Write(array[i] + " ");
            }

            Class1 obj = new Class1();
            int sumOdd = obj.Calculate(array);

            Console.WriteLine("\nСумма нечётных элементов = " + sumOdd);

            Console.ReadKey();
        }
    }
}
