using System;
using System.Collections.Generic;

/* The prime 41, can be written as the sum of six consecutive primes:

41 = 2 + 3 + 5 + 7 + 11 + 13
This is the longest sum of consecutive primes that adds to a prime below one-hundred.

The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.

Which prime, below one-million, can be written as the sum of the most consecutive primes? */

namespace ProjectEuler
{
    public class Problem50
    {
        public void Solve()
        {
            int target = 1000000;
            int largestCount = 0;
            int largestCountValue = 0;

            List<int> primes = MathFunctions.GetPrimesUnderLimit(target);
            primes.Insert(0, 0);

            Dictionary<int, int> sumOfPrimes = new Dictionary<int, int>();

            sumOfPrimes.Add(0, 0);

            for(int i = 1; i < primes.Count; i++)
            {
                sumOfPrimes.Add(primes[i], sumOfPrimes[primes[i - 1]] + primes[i]);
            }

            for(int i = 1; i < sumOfPrimes.Count; i++)
            {
                for(int j = i - 1; j >= 0; j--)
                {
                    if(sumOfPrimes[primes[i]] - sumOfPrimes[primes[j]] >= target)
                    {
                        break;
                    }

                    int count;
                    if(MathFunctions.isPrime(sumOfPrimes[primes[i]] - sumOfPrimes[primes[j]]))
                    {
                        count = i - j;
                        if(count > largestCount)
                        {
                            largestCount = count;
                            largestCountValue = sumOfPrimes[primes[i]] - sumOfPrimes[primes[j]];
                        }
                    }
                }
            }

            Console.Write(largestCountValue);
        }
    }
}
