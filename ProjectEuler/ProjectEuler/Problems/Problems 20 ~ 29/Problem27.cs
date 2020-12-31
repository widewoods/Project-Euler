using System;
using System.Collections.Generic;

/* Euler discovered the remarkable quadratic formula: n^2 + n + 41


It turns out that the formula will produce 40 primes for the consecutive integer values n >= 0, n <= 39.
However, when n = 40, 40^2 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41,
and certainly when n = 41, 41^2 + 41 + 41 is clearly divisible by 41.

The incredible formula n^2 - 79n + 1601 was discovered,
which produces 80 primes for the consecutive values n >= 0, n <= 79.
The product of the coefficients, −79 and 1601, is −126479.

Considering quadratics of the form: n^2 + an + b, where |a| < 1000 and |b| <= 1000

Find the product of the coefficients, a and b,
for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n=0. */

//Notes: b is always prime since when n = 0, n^2 + an + b = b
//Using the graph of the equation, the graph has to be above x axis to have positive numbers. Therefore, D = a^2 - 4b < 0
//When a < 0, there are non distinct primes, ex) a = -61 n(n + a) is same when n = 30 and n = 31

//I think there can be more optimization, but not sure how

namespace ProjectEuler
{
    public class Problem27
    {
        public void Solve()
        {
            List<int> primes = MathFunctions.GetPrimesUnderLimit(1000);
            int a, b;

            int largest_a = 0, largest_b = 0;

            int count = 0, largestConsecutiveCount = 0;

            for(a = -999; a < 1000; a++)
            {
                foreach(int prime in primes)
                {
                    b = prime;

                    int n = 1;
                    while(primes.Contains(n*n + a*n+ b))
                    {
                        count++;
                        n++;
                    }

                    if(count > largestConsecutiveCount)
                    {
                        largestConsecutiveCount = count;
                        largest_a = a;
                        largest_b = b;
                    }
                    count = 0;
                }
            }

            Console.Write(largest_a * largest_b);
        }
    }
}
