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
            int[,] matrixElementsSum = new int[,] { {0, 1, 1, 2}, { 0, 5, 0, 0}, { 2, 0, 3, 3} };

            int result = 0;
            for (int i = 0; i < matrixElementsSum.GetLength(0); i++)
            {
                for (int j = 0; j < matrixElementsSum.GetLength(1); j++)
                {
                    if (matrixElementsSum[i,j] == 0)
                    {
                        break;
                    }

                }
            }
        }
    }
}
