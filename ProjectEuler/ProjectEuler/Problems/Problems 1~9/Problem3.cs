using System;
using System.Collections.Generic;

//Problem: What is the largest prime factor of the number 600851475143?

namespace ProjectEuler
{
    public class Problem3
    {
        List<int> primeNumbers = new List<int>(){ 2 };

        public void Solve(long num, int i)
        {
            foreach (int prime in primeNumbers)
            {
                if (i % prime == 0)
                {
                    Solve(num, i + 1);
                    return;
                }
            }
            primeNumbers.Add(i);

            int currentPrime = i;

            if (currentPrime == num)
            {
                Console.WriteLine("The largest prime factor is: " + currentPrime);
                return;
            }
            if (num % currentPrime == 0)
            {
                Solve(num / currentPrime, currentPrime);
            }
            else
            {
                Solve(num, currentPrime);
            }
        }
    }
}
