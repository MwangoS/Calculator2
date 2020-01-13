using Microsoft.VisualStudio.TestTools.UnitTesting;
using statsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace statsOperations.Tests
{
    [TestClass()]
    public class StatsMeanTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            int[] values = { 1, 2, 3 };
            var mean = StatsMean.Mean(values);
            Assert.AreEqual(2, mean);
        }
    }
}