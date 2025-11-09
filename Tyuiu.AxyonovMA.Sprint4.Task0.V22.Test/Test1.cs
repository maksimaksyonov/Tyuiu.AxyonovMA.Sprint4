// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task0.V22.Test
// Description: Тест метода GetSumOddArrEl (Вариант 22)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task0.V22.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task0.V22.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_46_For_StaticArray()
        {
            Class1 obj = new Class1();
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            int result = obj.GetSumOddArrEl(array);

            Assert.AreEqual(46, result);
        }
    }
}
