// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task7.V20.Lib
// Description: Преобразование строки в матрицу n×m и нахождение произведения чётных чисел (Вариант 20)

using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AxyonovMA.Sprint4.Task7.V20.Lib
{
    public class Class1 : ISprint4Task7V20
    {
        // Метод принимает размеры матрицы n×m и строку value
        // Возвращает произведение всех чётных чисел
        public int Calculate(int n, int m, string value)
        {
            if (value.Length != n * m)
                throw new ArgumentException("Длина строки должна быть равна n * m.");

            int[,] matrix = new int[n, m];
            int index = 0;

            // Заполняем матрицу цифрами из строки
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            int product = 1;
            bool hasEven = false;

            // Вычисляем произведение чётных чисел
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }

            return hasEven ? product : 0;
        }
    }
}
