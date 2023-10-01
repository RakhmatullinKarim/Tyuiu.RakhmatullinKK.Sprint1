using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RakhmatullinKK.Sprint1.Task7.V3.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private const long Actual = 56837046373732;

        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.6, res);
        }
    }
}
