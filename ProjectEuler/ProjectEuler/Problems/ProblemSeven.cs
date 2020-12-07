using System;
using System.Collections.Generic;

//What is the 10 001st prime number?

namespace ProjectEuler
{
    public class ProblemSeven
    {
        List<int> primeNumbers = new List<int>() { 2 };

        public void Solve(int primeNumberCardinal)
        {
            int i = 2;
            int count = 0;

            while (primeNumbers.Count <= primeNumberCardinal)
            {
                i++;

                foreach(int prime in primeNumbers)
                {
                    if (i % prime == 0)
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }

                if(count == primeNumbers.Count)
                {
                    primeNumbers.Add(i);
                }

                count = 0;
            }

            Console.WriteLine("The " + primeNumberCardinal + "th prime is: " + primeNumbers[primeNumberCardinal - 1]);
        }
    }
}
