using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public class Rounding
    {
        public static dynamic RoundTwoDecimals(dynamic a)
        {
            return Math.Round(a, 3, MidpointRounding.ToEven);
        }

        public static dynamic RoundFourDecimals(dynamic a)
        {
            return Math.Round(a, 6, MidpointRounding.ToEven);
        }

        public static dynamic RoundFiveDecimals(dynamic a)
        {
            return Math.Round(a, 7, MidpointRounding.ToEven);
        }
    }
}
    

