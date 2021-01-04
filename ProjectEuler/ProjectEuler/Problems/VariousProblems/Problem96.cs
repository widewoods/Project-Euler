using System;
using System.Collections.Generic;
using System.Threading;

//Problem: https://projecteuler.net/problem=96

namespace ProjectEuler
{
    public class Problem96
    {
        List<string>[] horizontalLines = new List<string>[9];
        List<string>[] verticalLines = new List<string>[9];
        List<string>[] boxGrids = new List<string>[9];

        public string[,] Solve(string[,] puzzle)
        {
            if(puzzle.Length != 81)
            {
                return null;
            }

            Initialize(puzzle);

            Backtrack(puzzle, 0, 0);

            return puzzle;
        }

        void Initialize(string[,] puzzle)
        {
            for (int i = 0; i < 9; i++)
            {
                horizontalLines[i] = new List<string>();
                verticalLines[i] = new List<string>();
                boxGrids[i] = new List<string>();
                for(int j = 0; j < 9; j++)
                {
                    horizontalLines[i].Add("0");
                    verticalLines[i].Add("0");
                    boxGrids[i].Add("0");
                }
            }

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    horizontalLines[j][i] = puzzle[i, j];
                    verticalLines[i][j] = puzzle[i, j];
                    int gridIndex = 3 * (j / 3) + i / 3;
                    int smallGridIndex = i % 3 + 3 * (j % 3);

                    boxGrids[gridIndex][smallGridIndex] = puzzle[i, j];
                }
            }
        }

        bool TryChangeCell(string[,] puzzle, int x, int y, string value)
        {
            if(int.Parse(value) > 9 || int.Parse(value) < 0)
            {
                Console.Write("Invalid value.");
                return false;
            }

            int gridIndex = 3 * (y / 3) + x / 3;

            if (int.Parse(value) != 0)
            {
                if (horizontalLines[y].Contains(value))
                {
                    return false;
                }
                if (verticalLines[x].Contains(value))
                {
                    return false;
                }
                if (boxGrids[gridIndex].Contains(value))
                {
                    return false;
                }
            }

            puzzle[x, y] = value;

            horizontalLines[y][x] = puzzle[x, y];
            verticalLines[x][y] = puzzle[x, y];

            int smallGridIndex = x % 3 + 3 * (y % 3);

            boxGrids[gridIndex][smallGridIndex] = puzzle[x, y];

            return true;
        }

        bool Backtrack(string[,] puzzle, int x, int y)
        {
            while (puzzle[x, y] != "0")
            {
                x++;
                if(x > 8)
                {
                    y++;
                    x -= 9;
                }
                if(y == 9)
                {
                    //Console.Clear();
                    //for (int a = 0; a < 9; a++)
                    //{
                    //    for (int j = 0; j < 9; j++)
                    //    {
                    //        Console.Write(puzzle[j, a] + " ");
                    //    }
                    //    Console.WriteLine("");
                    //}
                    return true;
                }
            }

            for(int i = 1; i <= 9; i++)
            {
                if(TryChangeCell(puzzle, x, y, i.ToString()))
                {
                    if (Backtrack(puzzle, x, y))
                    {
                        return true;
                    }
                    else
                    {
                        TryChangeCell(puzzle, x, y, "0");
                        continue;
                    }
                }
                //Console.Clear();
                //for (int a = 0; a < 9; a++)
                //{
                //    for (int j = 0; j < 9; j++)
                //    {
                //        Console.Write(puzzle[j, a] + " ");
                //    }
                //    Console.WriteLine("");
                //}
                //Thread.Sleep(20);
            }

            return false;
        }
    }
}
