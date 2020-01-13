using System;
using Operations;

namespace Divide1
{
    public interface IDivide
    {
        public dynamic Divide(dynamic a, dynamic b);
    }
    public class Div : IDivide
    {
        public dynamic result;
        public dynamic Divide(dynamic a, dynamic b)
        {
            result = Division.Quotient(a, b);
            return result;
        }
    }
}
