using System;
using Operations;
using Sum;
using Divide1;

namespace Basic_Calculator1
{
    public interface IBasicCalculator
    {
        public dynamic Add(dynamic a, dynamic b);
        //public dynamic Divide(dynamic a, dynamic b);

    }

    public class Calculator : IAdd
    {
        // Creating objects of Geeks1 and Geeks2 class 
        private readonly Adding add = new Adding();
        private readonly Div divide = new Div();
        public dynamic result;

        public dynamic Add(dynamic a, dynamic b)
        {
            result = add.Add(a, b);
            return result;
        }

        /*public dynamic Divide(dynamic a, dynamic b)
        {
            result = divide.Divide(a, b);
            return result;

        }*/

    }
}