using System;
using System.Diagnostics;

namespace ProjectEuler
{
    class MainClass
    { 
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Problem14 problem = new Problem14();

            Console.Clear();

            sw.Restart();

            problem.FindStartNumWithLargestSteps(1000000);

            sw.Stop();

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}