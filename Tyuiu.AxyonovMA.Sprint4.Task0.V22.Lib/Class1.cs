// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task0.V22.Lib
// Description: Сумма нечётных элементов массива (Вариант 22)

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AxyonovMA.Sprint4.Task0.V22.Lib
{
    public class Class1 : ISprint4Task0V22
    {
        // Метод возвращает сумму нечётных элементов массива
        public int GetSumOddArrEl(int[] array)
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
