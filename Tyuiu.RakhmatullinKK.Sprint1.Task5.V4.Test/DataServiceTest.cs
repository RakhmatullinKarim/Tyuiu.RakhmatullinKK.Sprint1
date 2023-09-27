using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RakhmatullinKK.Sprint1.Task5.V4.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int time = 3600;
            var res = ds.SecondsToHours(time);
            Assert.AreEqual(1, res);
        }
    }
}
