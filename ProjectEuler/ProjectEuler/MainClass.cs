using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ProjectEuler
{
    class MainClass
    { 
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Problem20 problem = new Problem20();

            Console.Clear();

            sw.Restart();

            problem.Solve(100);

            sw.Stop(); 

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}