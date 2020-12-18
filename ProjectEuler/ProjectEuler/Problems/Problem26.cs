using System;
using System.Collections.Generic;

/* A unit fraction contains 1 in the numerator. 
The decimal representation of the unit fractions with denominators 2 to 10 are given:

1/2	= 	0.5
1/3	= 	0.(3)
1/4	= 	0.25
1/5	= 	0.2
1/6	= 	0.1(6)
1/7	= 	0.(142857)
1/8	= 	0.125
1/9	= 	0.(1)
1/10 = 	0.1
Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.

Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part. */

//From wikipedia : The period of 1/k for integer k is always <= k - 1

namespace ProjectEuler
{
    public class Problem26
    {
        public void Solve(int d)
        {
            int largestCycle = 0;
            int largestCycleDivisor = 0;

            for(int i = 2; i < d; i++)
            {
                List<int> repetend = FindRecurringDecimal(i);
                if(repetend.Count > largestCycle)
                {
                    largestCycle = repetend.Count;
                    largestCycleDivisor = i;
                }
            }

            Console.Write(largestCycleDivisor);
        }

        List<int> FindRecurringDecimal(int divisor)
        {
            List<int> decimals = new List<int>();
            int dividend = 1;
            int remainder = dividend % divisor;
            List<int> remainders = new List<int>();

            for(int i = 0; i < divisor; i++)
            {
                if(divisor > dividend)
                {
                    dividend *= 10;
                }
                decimals.Add(dividend / divisor);

                remainder = dividend % divisor;
                if (remainders.Contains(remainder))
                {
                    break;
                }
                remainders.Add(remainder);
                dividend = dividend % divisor;
            }

            for(int i = 0; i < remainders.IndexOf(remainder); i++)
            {
                decimals.RemoveAt(0);
            }

            return decimals;
        }
    }
}
