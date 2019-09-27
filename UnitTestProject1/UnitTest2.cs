using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using github;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
  
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\TestData.csv", "TestData#csv",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod1()
        {
            double x1 = double.Parse(TestContext.DataRow[0].ToString());
            double y1 = double.Parse(TestContext.DataRow[1].ToString());
            double x2 = double.Parse(TestContext.DataRow[2].ToString());
            double y2 = double.Parse(TestContext.DataRow[3].ToString());
            double expected = double.Parse(TestContext.DataRow[4].ToString());
            Diem d1 = new Diem(x1, y1);
            Diem d2 = new Diem(x2, y2);
            HCN h = new HCN(d1, d2);
            double actual = h.TinhDienTich();
            Assert.AreEqual(expected, actual);
        }


    }
}
