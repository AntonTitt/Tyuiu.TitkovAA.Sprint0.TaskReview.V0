using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int a = 4, b = 3, z = 9;
            int res = DataService.Calc(a, b, z);


            Assert.AreEqual(res, 80);
        }
    }
}
