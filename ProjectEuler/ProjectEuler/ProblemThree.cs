using System;
using System.Collections.Generic;

//Problem: What is the largest prime factor of the number 600851475143?

namespace ProjectEuler
{
    public class ProblemThree
    {
        List<int> primeNumbers = new List<int>(){ 2 };

        public void Solve(long num, int prime)
        {
            int currentPrime = GetNextPrimeNumber(prime + 1);

            if (currentPrime == num)
            {
                Console.WriteLine("The largest prime factor is: " + currentPrime);
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

        int GetNextPrimeNumber(int i)
        {
            foreach(int prime in primeNumbers)
            {
                if(i % prime == 0)
                {
                    int returnNum = GetNextPrimeNumber(i + 1);
                    return returnNum;
                }
            }
            primeNumbers.Add(i);
            return i;
        }
    }
}
