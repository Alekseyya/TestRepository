using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;

namespace TestForConsoleApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Program.Count(3, 5);

            Assert.AreEqual(8, result);
            
        }
    }
}
