using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint1.TaskReview.V16.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.TaskReview.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double wait = 1.022;
            var res = ds.Calculate(x);

            Assert.AreEqual(wait, res);

        }
    }
}
