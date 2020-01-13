using System;
using System.Collections.Generic;
using System.Text;
using Operations;

namespace statsOperations
{
    public class StatsVariance
    {
        public static double Variance(dynamic values)
        {
            double mean = StatsMean.Mean(values);
            double[] squaredDeviation = new double[Helpers.Arrays.Length(values)]; ;
            int i = 0;

            foreach (int a in values)
            {
                squaredDeviation[i] = (Subtraction.Subtract(a, mean));
                i++;
            }
            double variance = StatsMean.Mean(squaredDeviation);
            return variance;
        }
    }
}