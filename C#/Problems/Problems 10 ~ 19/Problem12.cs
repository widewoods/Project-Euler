﻿using System;
using System.Collections.Generic;

/* The sequence of triangle numbers is generated by adding the natural numbers.
So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

Let us list the factors of the first seven triangle numbers:

 1: 1
 3: 1,3
 6: 1,2,3,6
10: 1,2,5,10
15: 1,3,5,15
21: 1,3,7,21
28: 1,2,4,7,14,28
We can see that 28 is the first triangle number to have over five divisors.

What is the value of the first triangle number to have over five hundred divisors? */

namespace ProjectEuler
{
    public class Problem12
    {
        /* The nth triangle number is n(n+1)/2
        If n is odd, it always has the divisors (n+1)/2 and n
        If n is even, it always has the divisors n/2 and (n+1)

        The number of divisors that the nth triangle number has is
        equal to the product of the two divisors' number of divisors */

        int[] GetDivisors(int num)
        {
            List<int> divisors = new List<int>();
            for(int i = 1; i <= MathF.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    divisors.Add(i);
                    if(num/i != i)
                    {
                        divisors.Add(num / i);
                    }
                }
            }

            return divisors.ToArray();
        }

        public void Solve(int numberOfDivisors)
        {
            int triangleNum = 1;
            int divisor1 = 1;
            int divisor2 = 1;

            int currentNumberOfDivisors = GetDivisors(divisor1).Length * GetDivisors(divisor2).Length;

            int n = 1;

            while(currentNumberOfDivisors <= numberOfDivisors)
            {
                n++;
                triangleNum = n * (n + 1) / 2;

                if(n % 2 == 0)
                {
                    divisor1 = n / 2;
                    divisor2 = n + 1;
                }

                else
                {
                    divisor1 = (n + 1) / 2;
                    divisor2 = n;
                }

                currentNumberOfDivisors = GetDivisors(divisor1).Length * GetDivisors(divisor2).Length;
            }

            Console.WriteLine(triangleNum);
        }
    }
}