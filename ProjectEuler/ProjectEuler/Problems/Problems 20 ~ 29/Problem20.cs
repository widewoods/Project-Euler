using System;
using System.Collections.Generic;

/* n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits in the number 100! */

namespace ProjectEuler
{
    public class Problem20
    {
        int[] number = new int[200];
        int currentDigit = 0;
        int carry = 0;

        //Couldn't make a factorial function work myself, so I found a solution from https://jaykaychoi.tistory.com/64
        //Used solution once I understood it fully.

        void Factorial(int n)
        {
            number[0] = 1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 0; j <= currentDigit; j++)
                {
                    number[j] = number[j] * i + carry;
                    carry = 0;

                    if (number[j] >= 10)
                    {
                        carry = number[j] / 10;
                        number[j] = number[j] % 10;

                        //We know digit goes up by one when biggest digit * i >= 10
                        if (j == currentDigit)
                        {
                            currentDigit++;
                        }
                    }
                }
            }
        }

        public void Solve(int n)
        {
            Factorial(n);

            int sum = 0;

            foreach (int digit in number)
            {
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
