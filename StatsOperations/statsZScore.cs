using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace statsOperations
{
    public class StatsZScore
    {
        public static double ZScore(dynamic score, dynamic values)
        {
            double mean = StatsMean.Mean(values);
            double standDev = StatsStandardDev.StandardDev(values);
            double zScore = Division.Quotient(Subtraction.Subtract(score, mean), standDev);
            return zScore;
        }
    }
}