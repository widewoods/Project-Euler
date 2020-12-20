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

            Problem30 problem = new Problem30();

            Console.Clear();

            sw.Restart();

            problem.Solve();

            sw.Stop(); 

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}