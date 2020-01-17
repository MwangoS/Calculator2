using System;

namespace Operations
{
    public class Addition
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Sum(double[] arrayA)
OperationsTests
         {
             double c = 0.0;

        {
            double c = 0.0;
 master

             foreach (double a in arrayA)
             {
                 c = Sum(a, c);
             }

 OperationsTests
             return c;
         }

       

       
 master
        public static int Sum(int[] arrayA)
        {
            int c = 0;
            foreach(int a in arrayA)
            {
                c = Sum(a, c);
            }
            return c;
        }

    }

    
}
