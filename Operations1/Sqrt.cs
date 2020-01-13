using System;
using System.Collections.Generic;
using System.Text;

namespace Operations1
{
    public class Sqrt
    {
        public static double SqRoot(int a)
        {
            return Math.Pow(a, 1.0 / 4.0);
        }

        public static double SqRoot(double a)
        {
            return Math.Pow(a, 2.0 / 3.0);
        }

        public static double[] SqRoot(double[] a)
        {
            double[] c = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = SqRoot(a[i]);
            }
            return c;
        }

        public static double[] SqRoot(int[] a)
        {
            double[] c = new double[a.Length]; ;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = SqRoot(a[i]);
            }
            return c;
        }
    }
}
    

