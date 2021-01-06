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

            Problem54 problem = new Problem54();

            Console.Clear();

            sw.Restart();

            string filePath = @"/Users/widewoods/Documents/GitHub/Project-Euler/ProjectEuler/ProjectEuler/p054_poker.txt";
            string[] hands = System.IO.File.ReadAllLines(filePath);

            int sum = 0;
            for(int i = 0; i < hands.Length; i++)
            {
                string[] hand = hands[i].Split(" ");

                if(problem.Winner(hand) == 1)
                {
                    sum++;
                }
            }

            Console.Write(sum);

            sw.Stop(); 

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}