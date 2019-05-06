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
            int[] a = { 832, 998, 148, 570, 533, 561, 894, 147, 455, 279 };
            int[] b = { 832, 570, 148, 998, 533, 561, 455, 147, 894, 279 };
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] - b[i];
            }
            var result = c.Where(i => i != 0);
            var checking = a.Except(b);
            Console.WriteLine(checking.Count());
            if (result.Count() == 2 && result.Sum() == 0 || result.Count() == 0)
            {

            }
        }
    }
}
