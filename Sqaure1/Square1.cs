using System;
using Operations;

namespace Square
{
    public interface ISquare
    {
        public dynamic Square(dynamic a);
    }
    public class Squares : ISquare
    {
        public dynamic result;
        public dynamic Square(dynamic a)
        {
            result = Square(a);
            return result;
        }
    }
}
