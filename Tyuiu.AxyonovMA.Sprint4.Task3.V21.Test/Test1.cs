// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task3.V21.Test
// Description: Тест метода Calculate для варианта 21

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task3.V21.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task3.V21.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_10290_For_GivenMatrix()
        {
            int[,] a =
            {
                { 8, 3, 3, 3, 5 },
                { 6, 7, 3, 3, 7 },
                { 4, 5, 4, 6, 6 },
                { 5, 5, 8, 8, 7 },
                { 4, 6, 6, 7, 7 }
            };

            Class1 obj = new Class1();
            int actual = obj.Calculate(a);

            Assert.AreEqual(10290, actual);
        }
    }
}
