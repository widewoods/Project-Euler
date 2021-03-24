using System;
using System.Collections.Generic;

/* A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.

A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.

As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16,
the smallest number that can be written as the sum of two abundant numbers is 24.
By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
However, this upper limit cannot be reduced any further by analysis even though
it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.

Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers. */

//Abundant number properties from extra research
//Every multiple of a perfect number is abundant.
//Every multiple of an abundant number is abundant.

namespace ProjectEuler
{
    public class Problem23
    {
        List<int> abundantNumbers = new List<int>();

        int SumOfProperDivisors(int n)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i <= MathF.Round(MathF.Sqrt(n) - 0.5f); i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (n / i != i)
                    {
                        divisors.Add(n / i);
                    }
                }
            }

            divisors.Remove(n);

            int sum = 0;
            foreach (int divisor in divisors)
            {
                sum += divisor;
            }

            return sum;
        }

        void FindAbundantNumbers()
        {
            for(int i = 1; i <= 28123; i++)
            {
                if (i < SumOfProperDivisors(i))
                {
                    if (!abundantNumbers.Contains(i))
                    {
                        abundantNumbers.Add(i);
                    }
                }
            }
        }

        public void Solve()
        {
            FindAbundantNumbers();

            List<int> nonAbundantSums = new List<int>();

            for(int i = 1; i < 24; i++)
            {
                nonAbundantSums.Add(i);
            }

            int count = 0;
            int matchCount = 0;
            for(int i = 24; i <= 28123; i++)
            {
                foreach (int n in abundantNumbers)
                {
                    if (n > i/2)
                    {
                        break;
                    }
                    matchCount++;
                    if (!abundantNumbers.Contains(i - n))
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if(count == matchCount)
                {
                    nonAbundantSums.Add(i);
                }
                matchCount = 0;
                count = 0;
            }

            int sum = 0;

            foreach(int n in nonAbundantSums)
            {
                sum += n;
            }

            Console.Write(sum);
        }
    }
}
