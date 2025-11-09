// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task1.V16.Lib
// Description: Подсчёт произведения нечётных элементов массива (Вариант 16)

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AxyonovMA.Sprint4.Task1.V16.Lib
{
    public class Class1 : ISprint4Task1V16
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                    hasOdd = true;
                }
            }

            return hasOdd ? product : 0;
        }
    }
}
