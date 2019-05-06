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
            int[] a = { 50, 60, 60, 45, 70 };
            int[] b = new int[2];
            var b0 = a.Where((arr, index) => index % 2 == 0).Sum();
            Console.WriteLine(b0);
        }
    }
}
