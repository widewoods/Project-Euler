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

            Problem42 problem = new Problem42();

            Console.Clear();

            sw.Restart();

            string text = System.IO.File.ReadAllText(@"/Users/widewoods/Documents/GitHub/Project-Euler/ProjectEuler/ProjectEuler/p042_words.txt");

            string[] words = text.Split(",");

            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace("\"", "");
            }

            problem.Solve(words);

            sw.Stop(); 

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}