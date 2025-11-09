// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task2.V16.Lib
// Description: Сумма нечётных элементов массива, заполненного случайными числами (Вариант 16)

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AxyonovMA.Sprint4.Task2.V16.Lib
{
    public class Class1 : ISprint4Task2V16
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}
