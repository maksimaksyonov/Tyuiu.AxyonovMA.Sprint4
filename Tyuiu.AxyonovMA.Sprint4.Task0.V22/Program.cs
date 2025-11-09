// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task0.V22
// Description: Консольное приложение. Сумма нечётных элементов массива.

using System;
using Tyuiu.AxyonovMA.Sprint4.Task0.V22.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Одномерные массивы (статический ввод) | Задание #0 | Вариант #22 *");
            Console.WriteLine("***************************************************************************");

            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            Class1 obj = new Class1();
            int result = obj.GetSumOddArrEl(array);

            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine($"Сумма нечётных элементов = {result}");
            // Ожидаемый результат: 46

            Console.ReadKey();
        }
    }
}
