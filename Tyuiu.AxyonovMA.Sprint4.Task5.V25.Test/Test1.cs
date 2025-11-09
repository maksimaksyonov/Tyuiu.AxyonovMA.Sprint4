// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task5.V5.Test
// Description: Тест метода Calculate для варианта 5

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task5.V5.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_Correct_Sum_For_GivenMatrix()
        {
            int[,] matrix =
            {
                {  2, -1,  0,  3, -4 },
                { -2,  1,  2, -3,  3 },
                {  0,  3, -4,  1, -2 },
                {  3,  2, -1,  2,  0 },
                { -3, -4,  1,  1,  3 }
            };

            Class1 obj = new Class1();
            int result = obj.Calculate(matrix);

            // Положительные элементы: 2+3+1+2+3+3+1+3+2+2+1+1+3 = 24
            Assert.AreEqual(24, result);
        }
    }
}
