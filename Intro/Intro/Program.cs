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
            string inputString = "172.16.254.1";
            var dotCount = inputString.Where(i => i == '.').Count();
            if (dotCount != 3)
            {
                Console.WriteLine(false);
                return;
            }
            var nums = inputString.Split('.');
            Console.WriteLine(nums.Any(i => int.TryParse(i, out int result) || result < 0 || result > 255));


        }
    }
}
