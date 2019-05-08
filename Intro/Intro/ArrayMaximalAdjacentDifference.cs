using System;
using System.Collections.Generic;
using System.Linq;

namespace Intro
{
    class ArrayMaximalAdjacentDifference
    {
        int arrayMaximalAdjacentDifference(int[] inputArray)
        {
            List<int> sum = new List<int>();
            for (int i = 1; i < inputArray.Length - 1; i++)
            {
                sum.Add(Math.Max(Math.Abs(inputArray[i] - inputArray[i - 1]),
                                 Math.Abs(inputArray[i] - inputArray[i + 1])));
            }
            return sum.Max();
        }
    }
}
