using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class MainClass
    { 
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Problem16 problem = new Problem16();

            Console.Clear();

            sw.Restart();

            problem.Solve(1000);

            sw.Stop();

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}