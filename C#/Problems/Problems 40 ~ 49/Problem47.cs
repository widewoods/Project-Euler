using System;
using System.Collections.Generic;

/* The first two consecutive numbers to have two distinct prime factors are:

14 = 2 × 7
15 = 3 × 5

The first three consecutive numbers to have three distinct prime factors are:

644 = 2^2 × 7 × 23
645 = 3 × 5 × 43
646 = 2 × 17 × 19.

Find the first four consecutive integers to have four distinct prime factors each. What is the first of these numbers? */

namespace ProjectEuler
{
    public class Problem47
    {
        public void Solve()
        {
            bool found = false;
            int n = 0;

            int target = 4;

            while (!found)
            {
                n++;
                if(DistinctPrimeFactorCount(n) != target)
                {
                    continue;
                }

                int count = 1;
                for(int i = 1; i < target; i++)
                {
                    if(DistinctPrimeFactorCount(n + i) == target)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if(count == target)
                {
                    Console.WriteLine(n);
                    found = true;
                }
            }
        }

        int DistinctPrimeFactorCount(int n)
        {
            List<int> primes = MathFunctions.GetPrimesUnderLimit((int)MathF.Ceiling(MathF.Sqrt(n)));
            List<int> visitedPrimes = new List<int>();

            int count = 0;

            while(n != 1)
            {
                foreach(int prime in primes)
                {
                    if(n % prime == 0)
                    {
                        n = n / prime;
                        if (!visitedPrimes.Contains(prime))
                        {
                            visitedPrimes.Add(prime);
                            count++;
                        }
                    }
                }
                if (MathFunctions.isPrime(n)&& !visitedPrimes.Contains(n))
                {
                    count++;
                    break;
                }
            }

            return count;
        }
    }
}
