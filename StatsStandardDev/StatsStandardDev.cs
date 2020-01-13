using System;


namespace StandDev
{
    public class StatsStandardDev : IStandDev
    {
        public static dynamic result;

        public double StandDev(dynamic arrayB)
        {
            result = statsOperations.StatsStandardDev.StandardDev(arrayB);
            return result;
        }

        /*public static double StandardDev(dynamic values)
        {
            throw new NotImplementedException();
        }*/
    }
}