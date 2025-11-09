// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task7.V20.Test
// Description: Тест метода Calculate (Вариант 20)

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task7.V20.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task7.V20.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_768()
        {
            string input = "357951248632587";
            int n = 5, m = 3;

            Class1 obj = new Class1();
            int result = obj.Calculate(n, m, input);

            Assert.AreEqual(768, result);
        }
    }
}
