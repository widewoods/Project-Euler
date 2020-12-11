using System;

/* Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
there are exactly 6 routes to the bottom right corner.


How many such routes are there through a 20×20 grid? */

namespace ProjectEuler
{
    public class Problem15
    {
        long[,] numberOfPaths;

        public void Solve(int n, int m)
        {
            numberOfPaths = new long[n + 1, m + 1];
            for(int i = 0; i <= n; i++)
            {
                for(int j = 0; j <= m; j++)
                {
                    numberOfPaths[i, j] = 0;
                    if(i == 0 || j == 0)
                    {
                        numberOfPaths[i, j] = 1;
                    }
                }
            }

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= m; j++)
                {
                    numberOfPaths[i, j] = numberOfPaths[i - 1, j] + numberOfPaths[i, j - 1];
                }
            }

            Console.WriteLine(numberOfPaths[n, m]);
        }
    }
}
