using Microsoft.VisualStudio.TestTools.UnitTesting;
using statsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace statsOperations.Tests
{
    [TestClass()]
    public class StatsStandardDevTests
    {
        [TestMethod()]
        public void StandDevIntTest()
        {
            int[] values = { 1, 2, 3 };
            var standDev = StatsStandardDev.StandardDev(values);
            Assert.AreEqual(0.8165, Helpers.Rounding.RoundFiveDecimals(standDev));
        }
    }
}