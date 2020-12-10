using System;
using System.Collections.Generic;

//What is the 10 001st prime number?

namespace ProjectEuler
{
    public class ProblemSeven
    {
        /* 1 is not a prime
         * All primes except 2 are odd
         * All primes greater than 3 can be written as 6k +/- 1
         * Any number n can have only one prime factor greater than Sqrt(n)
         * The consequence for primality testing of a number n is: if we cannot find a number 
         * f less than or equal to Sqrt(n) that divides n then n is prime: the only primefactor of n is n itself */

        bool isPrime(int num)
        {
            if(num == 1)
            {
                return false;
            }
            else if(num < 4)
            {
                return true;
            }
            else if(num % 2 == 0)
            {
                return false;
            }
            else if(num < 9)
            {
                return true;
            }
            else if(num % 3 == 0)
            {
                return false;
            }
            else
            {
                int r = (int)MathF.Round((float)Math.Sqrt(num) + 0.5f);
                int f = 5;

                while(f <= r)
                {
                    if(num % f == 0)
                    {
                        return false;
                    }
                    if(num % (f+2) == 0)
                    {
                        return false;
                    }

                    f = f + 6;
                }
            }
            return true;
        }

        public void Solve(int limit)
        {
            int count = 1;
            int candidate = 1;

            while(count < limit)
            {
                candidate = candidate + 2;
                if (isPrime(candidate))
                {
                    count++;
                }
            }

            Console.WriteLine(candidate);
        }
    }
}
