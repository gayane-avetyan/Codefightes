using System;
using System.Linq;

namespace Intro
{
    class PalindromeRearranging
    {
        bool palindromeRearranging(string inputString)
        {
            char[] sortedArray = inputString.ToCharArray();
            Array.Sort(sortedArray);
            var even = sortedArray.Where((i, index) => index % 2 == 0).ToArray();
            var odd = sortedArray.Where((i, index) => index % 2 != 0).ToArray();
            if (inputString.Length % 2 == 0)
            {
                return new string(odd) == new string(even);
            }
            if (new string(even.Except(odd).ToArray()).Length <= 1)
            {
                return true;
            }
            return false;
        }
    }
}
