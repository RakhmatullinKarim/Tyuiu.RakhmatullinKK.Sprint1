using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RakhmatullinKK.Sprint1.Task3.V18.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3;
            double b = 1;
            double c = 1;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(3, res);
        }
    }
}
