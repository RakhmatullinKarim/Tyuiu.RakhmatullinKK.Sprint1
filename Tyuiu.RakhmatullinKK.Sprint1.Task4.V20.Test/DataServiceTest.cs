using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RakhmatullinKK.Sprint1.Task4.V20.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(4, res);
        }
    }
}
