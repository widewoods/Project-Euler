using System;
using System.Collections.Generic;

/* We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once. 
For example, 2143 is a 4-digit pandigital and is also prime.

What is the largest n-digit pandigital prime that exists? */

namespace ProjectEuler
{
    public class Problem41
    {
        public void Solve()
        {
            int largest = 0;
            List<string> digits = new List<string>();
            List<string> permutations = new List<string>();
            for (int n = 2; n < 10; n++)
            {
                digits.Clear();
                for(int i = 1; i <= n; i++)
                {
                    digits.Add(i.ToString());
                }

                permutations = MathFunctions.Permutate(digits);

                foreach(string num in permutations)
                {
                    int parsedNum = int.Parse(num);
                    if (MathFunctions.isPrime(parsedNum))
                    {
                        if(parsedNum > largest)
                        {
                            largest = parsedNum;
                        }
                    }
                }
            }

            Console.Write(largest);
        }
    }
}
