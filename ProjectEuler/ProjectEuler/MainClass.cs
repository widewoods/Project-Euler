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

            Problem46 problem = new Problem46();

            Console.Clear();

            sw.Restart();

            problem.Solve();

            sw.Stop(); 

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}