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

            Problem96 problem = new Problem96();

            Console.Clear();

            sw.Restart();

            string filePath = @"/Users/widewoods/Documents/GitHub/Project-Euler/ProjectEuler/ProjectEuler/p096_sudoku.txt";
            string[] text = System.IO.File.ReadAllLines(filePath);

            for(int i = 0; i < text.Length; i++)
            {
                text[i] = text[i].Trim();
            }

            List<string[,]> puzzles = new List<string[,]>();

            for(int i = 0; i < 50; i++)
            {
                puzzles.Add(new string[9, 9]);
                for(int j = 0; j < 9; j++)
                {
                    for(int k = 0; k < 9; k++)
                    {
                        puzzles[i][k, j] = text[10 * i + 1 + j][k].ToString();
                    }
                }
            }

            int sum = 0;
            for(int i = 0; i < 50; i++)
            {
                string[,] solved = problem.Solve(puzzles[i]);
                string topLeft = "";

                for(int j = 0; j < 3; j++)
                {
                    topLeft = topLeft + solved[j, 0];
                }

                sum += int.Parse(topLeft);
            }

            Console.Write(sum);

            sw.Stop(); 

            Console.WriteLine("\nTime Elapsed: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}