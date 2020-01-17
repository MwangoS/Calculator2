using System;
using Basic_Calculator1;
using StatsMean;
using StandDev;
//using StatsOperations;
using StatsZScore;

namespace StatisticsCalculator
{
    public class StatisticsCalculator : Calculator, IMean, IStandDev, IZScore //IFindVariance, 
    {
        private readonly StatsMean.StatsMean mean = new StatsMean.StatsMean();
        private readonly StandDev.StatsStandardDev StandardDev = new StandDev.StatsStandardDev();
        //private readonly FindVariance var = new FindVariance();
        private readonly FindZScore z = new FindZScore();

        public dynamic Mean(dynamic values)
        {
            return mean.Mean(values);
        }

        /*public double Variance(dynamic values)
        {
        */

        public double StandDev(dynamic values)
        {
            return StandardDev.StandDev(values);
        }

        public double ZScore(dynamic score, dynamic values)
        {
            return z.ZScore(score, values);
        }
    }
}