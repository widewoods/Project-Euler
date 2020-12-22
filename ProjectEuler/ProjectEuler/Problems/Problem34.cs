using System;
using System.Collections.Generic;

/* 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.

Find the sum of all numbers which are equal to the sum of the factorial of their digits.

Note: As 1! = 1 and 2! = 2 are not sums they are not included. */

namespace ProjectEuler
{
    public class Problem34
    {
        MathFunctions math = new MathFunctions();

        int sum = 0;
        int sumOfDigitFactorial = 0;

        Dictionary<int, int> factorialValues = new Dictionary<int, int>();

        public void Solve()
        {
            SetFactorialDict();

            for(int i = 3; i <= 2540160; i++)
            {
                int temp = i;
                while (temp != 0)
                {
                    sumOfDigitFactorial += factorialValues[temp % 10];
                    temp = temp / 10;
                }

                if(sumOfDigitFactorial == i)
                {
                    sum += i;
                }
                sumOfDigitFactorial = 0;
            }

            Console.Write(sum);
        }

        void SetFactorialDict()
        {
            for(int i = 0; i < 10; i++)
            {
                factorialValues.Add(i, math.Factorial(i));
            }
        }
    }
}
