﻿namespace Intro
{
    class ArrayChange
    {
        int arrayChange(int[] inputArray)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                while (inputArray[i] >= inputArray[i + 1])
                {
                    inputArray[i + 1]++;
                    count++;
                }
            }
            return count;
        }
    }
}
