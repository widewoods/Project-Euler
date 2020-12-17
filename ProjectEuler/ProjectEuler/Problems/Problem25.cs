using System;
using System.Collections.Generic;

/* The Fibonacci sequence is defined by the recurrence relation:

Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
Hence the first 12 terms will be:

F1 = 1
F2 = 1
F3 = 2
F4 = 3
F5 = 5
F6 = 8
F7 = 13
F8 = 21
F9 = 34
F10 = 55
F11 = 89
F12 = 144
The 12th term, F12, is the first term to contain three digits.

What is the index of the first term in the Fibonacci sequence to contain 1000 digits? */

namespace ProjectEuler
{
    public class Problem25
    {
        public void Solve()
        {
            int count = 2;
            List<int> num1 = new List<int>() { 1 };
            List<int> num2 = new List<int>() { 1 };

            while(num2.Count < 1000)
            {
                List<int> temp = new List<int>();
                temp.AddRange(num2);

                num2 = FibonacciStep(num1, num2);

                num1 = temp;

                count++;
            }

            Console.Write(count);
        }

        List<int> FibonacciStep(List<int> num1, List<int> num2)
        {
            int carry = 0;
            List<int> nextTerm = new List<int>();

            if(num2.Count > num1.Count)
            {
                for(int i = 0; i < num2.Count - num1.Count; i++)
                {
                    num1.Add(0);
                }
            }

            for(int i = 0; i < num1.Count; i++)
            {
                int sum = num1[i] + num2[i] + carry;

                nextTerm.Add(sum % 10);

                if (sum > 9)
                {
                    if (i == num1.Count - 1)
                    {
                        nextTerm.Add(sum / 10);
                    }
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            return nextTerm;
        }
    }
}
