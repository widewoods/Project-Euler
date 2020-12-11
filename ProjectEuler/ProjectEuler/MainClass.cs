using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class MainClass
    { 
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Problem15 problem = new Problem15();

            Console.Clear();

            sw.Restart();

            problem.Solve(20, 20);

            sw.Stop();

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}