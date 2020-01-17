using System;
using statsOperations;

namespace StatsZScore
{
    public class FindZScore : IZScore
    {
        public static dynamic result;

        public double ZScore(dynamic score, dynamic values)
        {
            result = statsOperations.StatsZScore.ZScore(score, values);
            return result;
        }
    }
}