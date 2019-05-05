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
            int n = 1230;
            int half = n.ToString().Length / 2;
            string leftPart = n.ToString().Substring(0, half);
            string rightPart = n.ToString().Substring(half);
            var result = n.ToString().Substring(0, half).Sum(l => Convert.ToInt32(l));
            var result2 = n.ToString().Substring(half).Sum(r => Convert.ToInt32(r));
            Console.WriteLine(result2);
            //int left = 0;
            //int right = 0;
            //for (int i = 0; i < half; i++)
            //{
            //    left += leftPart % 10;
            //    leftPart /= 10;

            //    right += rightPart % 10;
            //    rightPart /= 10;
            //}
        }
    }
}
