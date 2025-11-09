// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task5.V5.Lib
// Description: Сумма положительных элементов двумерного массива (Вариант 5)

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AxyonovMA.Sprint4.Task5.V5.Lib
{
    public class Class1 : ISprint4Task5V25
    {
        // Возвращает сумму положительных элементов двумерного массива
        public int Calculate(int[,] array)
        {
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        sum += array[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
