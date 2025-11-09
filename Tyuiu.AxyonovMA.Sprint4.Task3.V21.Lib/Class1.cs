// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task3.V21.Lib
// Description: Произведение элементов последнего столбца (5x5, статический ввод)

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AxyonovMA.Sprint4.Task3.V21.Lib
{
    public class Class1 : ISprint4Task3V21
    {
        // Возвращает произведение элементов последнего столбца массива
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int lastCol = cols - 1;
            int product = 1;

            for (int i = 0; i < rows; i++)
            {
                product *= array[i, lastCol];
            }

            return product;
        }
    }
}
