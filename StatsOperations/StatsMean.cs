using System;
using Operations;
using statsOperations;



namespace statsOperations
{
    public class StatsMean
    {
        public static dynamic Mean(dynamic values)
        {
            var Sum = Addition.Sum(values);
            var valueCount = Helpers.Arrays.Length(values);
            var mean = Division.Quotient(Sum, valueCount);
            return mean;
        }
    }
}