using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatCalculatorTests
    {
        private readonly StatisticsCalculator statCalc = new StatisticsCalculator();
        private readonly int[] values = { 1, 2, 3 };
        private readonly int score = 4;
        private readonly double[] doubleVal = { 2.1, 1.1 };
        private readonly double doubleScore = 2.2;

        [TestMethod()]
        public void MeanIntTest()
        {
            var mean = statCalc.Mean(values);
            Assert.AreEqual(2, mean);
        }

        /*[TestMethod()]
        public void VarianceIntTest()
        {
            var variance = statCalc.variance(values);
            Assert.AreEqual(2, Helpers.Rounding.RoundFiveDecimals(variance));
        }*/

        [TestMethod()]
        public void StandDevIntTest()
        {
            var standDev = statCalc.StandDev(values);
            Assert.AreEqual(0, Helpers.Rounding.RoundFiveDecimals(standDev));
        }

        [TestMethod()]
        public void ZScoreIntTest()
        {
            var z = statCalc.ZScore(score, values);
            Assert.AreEqual(0, Helpers.Rounding.RoundFiveDecimals(z));
        }

        [TestMethod()]
        public void MeanDoubleTest()
        {
            var mean = statCalc.Mean(doubleVal);
            Assert.AreEqual(1.6, mean);
        }

        /*[TestMethod()]
        public void VarianceDoubleTest()
        {
            var variance = statCalc.statsVariance(doubleVal);
            Assert.AreEqual(2.09, Helpers.Rounding.RoundFiveDecimals(variance));
        }*/

        [TestMethod()]
        public void StandDevDoubleTest()
        {
            var standDev = statCalc.StandDev(doubleVal);
            Assert.AreEqual(0.7071, Helpers.Rounding.RoundFiveDecimals(standDev));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            var z = statCalc.ZScore(doubleScore, doubleVal);
            Assert.AreEqual(5.3740, Helpers.Rounding.RoundFiveDecimals(z));
        }
    }
}
