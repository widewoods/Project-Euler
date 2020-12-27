using System;
using System.Collections.Generic;

/* If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, 
there are exactly three solutions for p = 120.

{20,48,52}, {24,45,51}, {30,40,50}

For which value of p ≤ 1000, is the number of solutions maximised? */

namespace ProjectEuler
{
    public class Problem39
    {
        Dictionary<(int, int, int), int> tripletPerimeter = new Dictionary<(int, int, int), int>();

        int largestSolutionCount = 0;
        int largestSolutionP;

        public void Solve()
        {
            for(int m = 2; m < 24; m++)
            {
                for (int n = m - 1; n >= 1; n -= 2)
                {
                    if (MathFunctions.GCD(m, n) == 1)
                    {
                        if (2 * m * (m + n) <= 1000)
                        {
                            tripletPerimeter.Add((m * m - n * n, 2 * m * n, m * m + n * n), 2 * m * (m + n));
                        }
                    }
                }
            }

            for (int p = 8; p <= 1000; p += 2)
            {
                int solutionCount = 0;
                foreach(KeyValuePair<(int, int, int), int> keyValuePair in tripletPerimeter)
                {
                    if(p % keyValuePair.Value == 0)
                    {
                        solutionCount++;
                    }
                }

                if(solutionCount > largestSolutionCount)
                {
                    largestSolutionCount = solutionCount;
                    largestSolutionP = p;
                }
            }

            Console.Write(largestSolutionP);
        }
    }
}
