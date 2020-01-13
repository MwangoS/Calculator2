using System;
using Operations1;

namespace SquareRoot
{
    public class SquareRoot : ISquareRoot
    {
        public dynamic result;

        public dynamic SqRoot(dynamic a)
        {
            result = Sqrt.SqRoot(a);
            return result;
        }
    }
}
    


