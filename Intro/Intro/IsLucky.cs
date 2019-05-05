using System;
using System.Linq;

namespace Intro
{
    class IsLucky
    {
        bool isLucky(int n)
        {
            int half = n.ToString().Length / 2;
            return n.ToString().Substring(0, half).Sum(l => Convert.ToInt32(l)) == n.ToString().Substring(half).Sum(r => Convert.ToInt32(r));
        }
    }
}
