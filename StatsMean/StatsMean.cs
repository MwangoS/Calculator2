using System;
using Operations;

namespace StatsMean
{
    public class StatsMean : IMean
    {
        public static dynamic result;

        public dynamic Mean(dynamic a)
        {
            result = statsOperations.StatsMean.Mean(a);
            return result;
        }
    }
}