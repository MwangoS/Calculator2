using System;
using Operations;

namespace Subtract
{
    public interface ISubtract
    {
        public dynamic Subtracts(dynamic a, dynamic b);
    }
    public class Sub : ISubtract
    {
        public dynamic result;
        public dynamic Subtracts(dynamic a, dynamic b)
        {
            result = Subtraction.Subtract(a, b);
            return result;
        }
    }
}
