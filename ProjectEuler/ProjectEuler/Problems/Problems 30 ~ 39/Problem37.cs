using System;
using System.Collections.Generic;

/* The number 3797 has an interesting property. Being prime itself, it is possible to continuously remove digits from left to right, 
and remain prime at each stage: 3797, 797, 97, and 7.Similarly we can work from right to left: 3797, 379, 37, and 3.

Find the sum of the only eleven primes that are both truncatable from left to right and right to left.

NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes. */

namespace ProjectEuler
{
    public class Problem37
    {
        List<int> primes = MathFunctions.GetPrimesUnderLimit(1000000);

        public void Solve()
        {
            int sum = 0;

            foreach(int prime in primes)
            {
                if (isTruncatablePrime(prime))
                {
                    sum += prime;
                }
            }

            Console.Write(sum);
        }

        bool isTruncatablePrime(int prime)
        {
            int[] digits = MathFunctions.IntToDigitArray(prime);

            if(digits.Length == 1)
            {
                return false;
            }

            for(int i = 0; i < digits.Length; i++)
            {
                if(i != digits.Length - 1)
                {
                    if(digits[i] % 2 == 0 || digits[i] % 5 == 0)
                    {
                        return false;
                    }
                }
            }

            int truncateFromLeft = prime;

            for(int i = 1; i < digits.Length; i++)
            {
                truncateFromLeft = truncateFromLeft % (int)MathF.Pow(10, digits.Length - i);

                if (!primes.Contains(truncateFromLeft))
                {
                    return false;
                }
            }

            int truncateFromRight = prime;

            for(int i = 1; i < digits.Length; i++)
            {
                truncateFromRight = truncateFromRight / 10;

                if (!primes.Contains(truncateFromRight))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
