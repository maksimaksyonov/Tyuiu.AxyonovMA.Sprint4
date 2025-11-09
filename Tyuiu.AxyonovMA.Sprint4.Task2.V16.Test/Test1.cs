// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task2.V16.Test
// Description: Тест метода Calculate (Вариант 16)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task2.V16.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_Correct_Sum_For_KnownArray()
        {
            Class1 obj = new Class1();
            int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 3, 2 };

            int result = obj.Calculate(array);

            // Нечётные: 3 + 5 + 7 + 9 + 3 = 27
            Assert.AreEqual(27, result);
        }
    }
}
