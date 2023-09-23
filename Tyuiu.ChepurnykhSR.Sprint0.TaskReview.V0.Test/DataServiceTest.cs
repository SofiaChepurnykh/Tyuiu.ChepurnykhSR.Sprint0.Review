using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 5;
            int y = 10;
            int z = 20;

            int res = DataService.Calc(x, y, z);

            Assert.AreEqual(175, res);
        }
    }
}
