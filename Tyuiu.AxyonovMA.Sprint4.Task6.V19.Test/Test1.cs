// Author: Максим Аксёнов
// Project: Tyuiu.AxyonovMA.Sprint4.Task6.V19.Test
// Description: Тест метода Calculate для варианта 19

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.AxyonovMA.Sprint4.Task6.V19.Lib;

namespace Tyuiu.AxyonovMA.Sprint4.Task6.V19.Test
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Should_Return_4()
        {
            string[] browsers = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };

            Class1 obj = new Class1();
            int result = obj.Calculate(browsers);

            Assert.AreEqual(4, result);
        }
    }
}
