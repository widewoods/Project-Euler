using System;
using System.Collections.Generic;

/* The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.

There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.

How many circular primes are there below one million? */

namespace ProjectEuler
{
    public class Problem35
    {
        MathFunctions math = new MathFunctions();
        List<int> primes;

        public void Solve()
        {
            int count = 0;
            primes = math.GetPrimesUnderLimit(1000000);

            foreach(int prime in primes)
            {
                if (isCircularPrime(prime))
                {
                    count++;
                }
            }

            Console.Write(count);
        }

        bool isCircularPrime(int prime)
        {
            int digitCount = (int)MathF.Round(MathF.Log10(prime) - 0.5f) + 1;
            int[] digits = new int[digitCount];

            for(int i = 0; i < digitCount; i++)
            {
                digits[i] = prime % 10;
                if(prime > 9)
                {
                    prime = prime / 10;
                }
            }

            int[] cycledNumbers = new int[digitCount];

            for(int i = 0; i < digitCount; i++)
            {
                int temp1 = digits[0];
                int temp2;
                for(int a = 0; a < digitCount; a++)
                {
                    cycledNumbers[i] += digits[a] * (int)MathF.Pow(10, a);
                }

                for(int j = 0; j < digitCount; j++)
                {
                    if(j == digitCount - 1)
                    {
                        digits[0] = temp1;
                    }
                    else if(j == 0)
                    {
                        temp1 = digits[1];
                        digits[1] = digits[0];
                    }
                    else
                    {
                        temp2 = digits[j + 1];
                        digits[j + 1] = temp1;
                        temp1 = temp2;
                    }
                }
            }

            int count = 0;
            foreach(int n in cycledNumbers)
            {
                if (primes.Contains(n))
                {
                    count++;
                }
            }

            if(count == digitCount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
