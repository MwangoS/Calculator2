﻿using System;
using Operations;

namespace Sum
{
    public interface IAdd
    {
        public dynamic Add(dynamic a, dynamic b);
    }
    public class Adding : IAdd
    {
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        /* public double Add(double[] values)
         {
             result = Addition.Sum(values);
             return result;
         }*/
    }
}
