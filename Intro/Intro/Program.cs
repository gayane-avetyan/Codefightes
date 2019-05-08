using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 3, 5, 6, 7, 9 };
            Array.Sort(inputArray);
            int result = 1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                while (inputArray[i] % result == 0)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
