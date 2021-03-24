using System;
using System.Collections.Generic;

/* The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.

Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000. */

namespace ProjectEuler
{
    public class Problem48
    {
        public void Solve()
        {
            List<int> sum = new List<int>() { 0 };

            for(int i = 1; i <= 1000; i++)
            {
                List<int> a = MathFunctions.LargePower(i, i);
                if(a.Count > 10)
                {
                    a.RemoveRange(10, a.Count - 10);
                }
                sum = MathFunctions.AddLargeInt(a, sum);
                if (sum.Count > 10)
                {
                    sum.RemoveRange(10, sum.Count - 10);
                }
            }

            for(int i = 9; i >= 0; i--)
            {
                Console.Write(sum[i]);
            }
        }
    }
}
