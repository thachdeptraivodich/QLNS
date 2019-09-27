using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using github;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }
            [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                @".\TextData.csv", "TextData#csv",
                DataAccessMethod.Sequential)]
            [TestMethod]
            public void TestWithDataSource()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int expected = int.Parse(TestContext.DataRow[2].ToString());
            caculation c = new caculation(a, b);
            int actual = c.execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testwithN0()
        {
            double expected = 1;
            double actual =Class1.Power(5, 0);
            Assert.AreEqual(expected, actual);
        }
      
    }
}