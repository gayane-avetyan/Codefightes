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
            //string inputString = "zyryzzzzz";
            string inputString = "yayaywl";
            char[] sortedArray = inputString.ToCharArray();
            Array.Sort(sortedArray);
            var even = sortedArray.Where((i, index) => index % 2 == 0).ToArray();
            var odd = sortedArray.Where((i, index) => index % 2 != 0).ToArray();
           
            string result = new string(odd) + new string(even);
            Console.WriteLine(new string(even.Except(odd).ToArray()));

            //Console.WriteLine(new string(result.Reverse().ToArray()));

            //if (inputString.Length % 2 == 0)
            //{
            //    Console.WriteLine(new string(odd) == new string(even));
            //    return;
            //}
           

            //if (new string(even.Except(odd).ToArray()).Length == 1)
            //{
            //    Console.WriteLine(true);
            //    return;
            //}










        }
    }
}
