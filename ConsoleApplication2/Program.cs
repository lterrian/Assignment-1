﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int x = 0; x <= 100; x++)
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }

        }
    }
}
