// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task1.V16
// Description: Консольное приложение для ввода массива и вычисления произведения нечётных элементов

using System;
using Tyuiu.AxyonovMA.Sprint4.Task1.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Аксёнов Максим Алексеевич | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4 | Одномерные массивы (ввод с клавиатуры) | Задание #1 | Вариант #16 *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[13];
            Console.WriteLine("Введите 13 целых чисел в диапазоне от 3 до 8:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент [{i + 1}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Class1 obj = new Class1();
            int result = obj.Calculate(array);

            Console.WriteLine("\nИсходный массив:");
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine($"\nПроизведение нечётных элементов = {result}");
            Console.ReadKey();
        }
    }
}
