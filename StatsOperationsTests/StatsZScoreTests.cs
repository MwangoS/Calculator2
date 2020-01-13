using Microsoft.VisualStudio.TestTools.UnitTesting;
using statsOperations;
using System;
using System.Collections.Generic;
using System.Text;

namespace statsOperations.Tests
{
    [TestClass()]
    public class StatsZScoreTests
    {
        [TestMethod()]
        public void ZScoreIntTest()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int score = 4;
            var zScore = StatsZScore.ZScore(score, values);
            Assert.AreEqual(0.70711, Helpers.Rounding.RoundFiveDecimals(zScore));
        }

        [TestMethod()]
        public void ZScoreDoubleTest()
        {
            double[] values = { 1.0, 2.5, 3.3 };
            double score = 2.2;
            var zScore = StatsZScore.ZScore(score, values);
            Assert.AreEqual(-0.76089, Helpers.Rounding.RoundFiveDecimals(zScore));
        }
    }
}