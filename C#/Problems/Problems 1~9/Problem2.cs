using System;
using System.Collections.Generic;

/*Problem: By considering the terms in the Fibonacci
           sequence whose values do not exceed four million,
           find the sum of the even-valued terms. */

namespace ProjectEuler
{
    public class Problem2
    {
        public static void Solve()
        {
            List<int> fibonacciNumbers = new List<int>();
            fibonacciNumbers.Add(1);
            fibonacciNumbers.Add(2);

            int i = 0;
            while(fibonacciNumbers[i + 1] < 4 * Math.Pow(10, 6))
            {
                int a = fibonacciNumbers[i];
                int b = fibonacciNumbers[i + 1];

                fibonacciNumbers.Add(a + b);

                i++;
            }

            int sumOfEvenFibonacciNumbers = 0;
            foreach(int num in fibonacciNumbers)
            {
                if(num % 2 == 0)
                {
                    sumOfEvenFibonacciNumbers += num;
                }
            }

            Console.WriteLine("Sum: " + sumOfEvenFibonacciNumbers);
        }
    }
}
