using System;
using Operations;

namespace Multiple
{
    public interface IMultiply
    {
        public dynamic Multiplication(dynamic a, dynamic b);
    }
    public class Multiple : IMultiply
    {
        public dynamic result;
        public dynamic Multiplication(dynamic a, dynamic b)
        {
            result = Multiplication(a, b);
            return result;
        }
    }


}
