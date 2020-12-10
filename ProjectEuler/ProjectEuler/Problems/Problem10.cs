using System;
using System.Collections.Generic;


namespace ProjectEuler
{
    public class Problem10
    {
        //List<int> primeNumbers = new List<int>() { 2 };

        public void Solve(int limit)
        {
            long sum = 0;

            bool[] crossed = FindPrimes(limit);

            for(int i = 2; i < limit; i++)
            {
                if(!crossed[i - 2])
                {
                    sum += i;
                }
            }

            Console.Write(sum);
        }

        bool[] FindPrimes(int limit)
        {
            bool[] crossed = new bool[limit - 2];
            //crossed[0] corresponds to number 2;

            for(int i = 4; i < limit; i += 2)
            {
                crossed[i - 2] = true;
            }

            for(int i = 3; i < MathF.Sqrt(limit); i++)
            {
                if (!crossed[i - 2])
                {
                    for(int j = i * i; j < limit; j += 2 * i)
                    {
                        crossed[j - 2] = true;
                    }
                }
            }

            return crossed;
        }
    }
}
