// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task4.V5.Test
// Description: Тест метода Calculate для варианта 5

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task4.V5.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task4.V5.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_78_For_GivenMatrix()
        {
            int[,] matrix =
            {
                { 6, 3, 6, 6, 7 },
                { 9, 8, 9, 7, 9 },
                { 5, 6, 8, 7, 5 },
                { 8, 5, 6, 5, 3 },
                { 3, 9, 9, 8, 8 }
            };

            Class1 obj = new Class1();
            int result = obj.Calculate(matrix);

            Assert.AreEqual(78, result);
        }
    }
}
