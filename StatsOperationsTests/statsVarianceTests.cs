using Microsoft.VisualStudio.TestTools.UnitTesting;
using statsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace statsOperations.Tests
{
    [TestClass()]
    public class StatsVarianceTests
    {
        [TestMethod()]
        public void VarianceIntTest()
        {
            int[] values = { 1, 2, 3 };
            var variance = StatsVariance.Variance(values);
            Assert.AreEqual(2, Helpers.Rounding.RoundTwoDecimals(variance));
        }
    }
}