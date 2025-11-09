// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task6.V19.Lib
// Description: Подсчёт количества строк длиной > 5 (Вариант 19)

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AxyonovMA.Sprint4.Task6.V19.Lib
{
    public class Class1 : ISprint4Task6V19
    {
        // Метод считает количество элементов массива, длина которых > 5
        public int Calculate(string[] array)
        {
            int count = 0;

            // Используем класс Array для перебора
            Array.ForEach(array, item =>
            {
                if (item.Length > 5)
                {
                    count++;
                }
            });

            return count;
        }
    }
}
