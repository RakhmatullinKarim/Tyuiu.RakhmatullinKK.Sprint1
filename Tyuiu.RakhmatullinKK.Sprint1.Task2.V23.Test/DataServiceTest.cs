using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RakhmatullinKK.Sprint1.Task2.V23.Lib;

namespace Tyuiu.RakhmatullinKK.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 3;
            var res = ds.ConvertMinutesToSeconds(value);
            Assert.AreEqual(180, res);
        }
    }
}
