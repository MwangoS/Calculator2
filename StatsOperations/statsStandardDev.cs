using System;
using System.Collections.Generic;
using System.Text;
using Operations1;

namespace statsOperations
{
    public class StatsStandardDev
    {
        public static double StandardDev(dynamic values)
        {
            double variance = StatsVariance.Variance(values);
            double standDev = Sqrt.SqRoot(variance);

            return standDev;
        }
    }
}