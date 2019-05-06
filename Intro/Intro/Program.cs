﻿using System;
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
            string[] picture = { "abc", "ded" };
            string asterix = new string('*', picture[0].Length + 2);
            string[] result = new string[picture.Length + 2];
            result[0] = asterix;
            for (int i = 1; i < result.Length - 1; i++)
            {
                result[i] = "*" + picture[i - 1] + "*";
            }
            result[picture.Length + 1] = asterix;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
