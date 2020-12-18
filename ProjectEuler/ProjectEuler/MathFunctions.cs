using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class MathFunctions
    {
        bool isPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            else if (num < 4)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else if (num < 9)
            {
                return true;
            }
            else if (num % 3 == 0)
            {
                return false;
            }
            else
            {
                int r = (int)MathF.Round((float)Math.Sqrt(num) + 0.5f);
                int f = 5;

                while (f <= r)
                {
                    if (num % f == 0)
                    {
                        return false;
                    }
                    if (num % (f + 2) == 0)
                    {
                        return false;
                    }

                    f = f + 6;
                }
            }
            return true;
        }

        public List<int> GetPrimesUnderLimit(int limit)
        {
            int count = 1;
            int candidate = 1;
            List<int> primes = new List<int>() { 2 };

            while (candidate < limit)
            {
                candidate = candidate + 2;
                if (isPrime(candidate))
                {
                    count++;
                    primes.Add(candidate);
                }
            }

            return primes;
        }
    }
}
