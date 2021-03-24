using System;
using System.Collections.Generic;

/* The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: 
(i) each of the three terms are prime, and,
(ii) each of the 4-digit numbers are permutations of one another.

There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property,
but there is one other 4-digit increasing sequence.

What 12-digit number do you form by concatenating the three terms in this sequence? */

namespace ProjectEuler
{
    public class Problem49
    {
        public void Solve()
        {
            List<int> primes = MathFunctions.GetPrimesUnderLimit(10000);

            foreach(int prime in primes)
            {
                if(prime >= 1000)
                {
                    int[] digits = MathFunctions.IntToDigitArray(prime);
                    List<string> digitStr = new List<string>();
                    foreach (int digit in digits)
                    {
                        digitStr.Add(digit.ToString());
                    }

                    List<string> permutations = MathFunctions.Permutate(digitStr);

                    int match = 1;
                    for (int i = 1; i < 3; i++)
                    {
                        if (MathFunctions.isPrime(prime + 3330 * i) && permutations.Contains((prime + 3330 * i).ToString()))
                        {
                            match++;
                        }
                    }
                    if (match == 3)
                    {
                        for(int i = 0; i < 3; i++)
                        {
                            Console.Write(prime + 3330 * i);
                        }
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
