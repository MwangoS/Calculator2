using System;
using Operations;

namespace CubeNumber
{
    public interface ICube
    {
        public dynamic CubeNumber(dynamic c);
    }
    public class Cubed
    {
        public dynamic result;
        public dynamic CubeNumber(dynamic c)
        {
            result = CubeNumber(c);
            return result;
        }
    }
}
