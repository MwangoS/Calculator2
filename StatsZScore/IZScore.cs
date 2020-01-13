using System;
using System.Collections.Generic;
using System.Text;

namespace StatsZScore
{
    public interface IZScore
    {
        public double ZScore(dynamic score, dynamic values);
    }
}
