// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task1.V16.Test
// Description: Тест метода Calculate (Вариант 16)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task1.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task1.V16.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_35721_For_SampleArray()
        {
            Class1 obj = new Class1();
            int[] array = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };

            int result = obj.Calculate(array);

            Assert.AreEqual(35721, result);
        }
    }
}
