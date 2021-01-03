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

            Problem59 problem = new Problem59();

            Console.Clear();

            sw.Restart();

            string filePath = @"/Users/widewoods/Documents/GitHub/Project-Euler/ProjectEuler/ProjectEuler/p059_cipher.txt";
            string text = System.IO.File.ReadAllText(filePath);

            text = text.Replace(",", " ");

            problem.Solve(text);

            sw.Stop(); 

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}