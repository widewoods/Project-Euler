using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem21
    {
        int SumOfProperDivisors(int n)
        {
            List<int> divisors = new List<int>();

            for(int i = 1; i <= MathF.Round(MathF.Sqrt(n) - 0.5f); i++)
            {
                if(n % i == 0)
                {
                    divisors.Add(i);
                    if(n/i != i)
                    {
                        divisors.Add(n / i);
                    }
                }
            }

            divisors.Remove(n);

            int sum = 0;
            foreach(int divisor in divisors)
            {
                sum += divisor;
            }

            return sum;
        }

        List<int> amicableNumbers = new List<int>();

        void FindAmicableNumber(int n)
        {
            int sumOfDivisors = SumOfProperDivisors(n);

            if(SumOfProperDivisors(sumOfDivisors) == n && n != sumOfDivisors && !amicableNumbers.Contains(n))
            {
                amicableNumbers.Add(n);
                amicableNumbers.Add(sumOfDivisors);
            }
        }

        public void Solve()
        {
            for(int i = 1; i < 10000; i++)
            {
                FindAmicableNumber(i);
            }

            int sum = 0;

            foreach(int n in amicableNumbers)
            {
                sum += n;
            }

            Console.WriteLine(sum);
        }
    }
}
