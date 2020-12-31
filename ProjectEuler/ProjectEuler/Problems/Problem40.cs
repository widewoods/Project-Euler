using System;

/* An irrational decimal fraction is created by concatenating the positive integers:

0.123456789101112131415161718192021...

It can be seen that the 12th digit of the fractional part is 1.

If d(n) represents the nth digit of the fractional part, find the value of the following expression.

d(1) × d(10) × d(100) × d(1000) × d(10000) × d(100000) × d(1000000) */

namespace ProjectEuler
{
    public class Problem40
    {
        public void Solve()
        {
            int product = 1;
            int count = 0;

            int i = 1;
            int goalIndex = 1;
            while(count <= 1000000)
            {
                int[] digits = MathFunctions.IntToDigitArray(i);

                for (int j = digits.Length - 1; j >= 0; j--)
                {
                    count++;
                    if(count == goalIndex)
                    {
                        goalIndex *= 10;
                        product *= digits[j];
                    }
                }
                i++;
            }

            Console.Write(product);
        }
    }
}
