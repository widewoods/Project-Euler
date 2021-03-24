using System;
using System.Collections.Generic;

/* The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, 
but it also has a rather interesting sub-string divisibility property.

Let d1 be the 1st digit, d2 be the 2nd digit, and so on. In this way, we note the following:

d2d3d4 = 406 is divisible by 2
d3d4d5 = 063 is divisible by 3
d4d5d6 = 635 is divisible by 5
d5d6d7 = 357 is divisible by 7
d6d7d8 = 572 is divisible by 11
d7d8d9 = 728 is divisible by 13
d8d9d10 = 289 is divisible by 17
Find the sum of all 0 to 9 pandigital numbers with this property. */

namespace ProjectEuler
{
    public class Problem43
    {
        List<int> primes = MathFunctions.GetPrimesUnderLimit(18);
        public void Solve()
        {
            List<string> digits = new List<string>();
            for(int i = 0; i < 10; i++)
            {
                digits.Add(i.ToString());
            }

            List<string> permutations = new List<string>();
            permutations = MathFunctions.Permutate(digits);

            long sum = 0;
            foreach(string p in permutations)
            {
                if (hasProperty(p))
                {
                    sum += long.Parse(p);
                }
            }

            Console.Write(sum);
        }

        bool hasProperty(string p)
        {
            for (int i = 1; i < 8; i++)
            {
                string substring = p.Substring(i, 3);
                if (long.Parse(substring) % primes[i - 1] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
