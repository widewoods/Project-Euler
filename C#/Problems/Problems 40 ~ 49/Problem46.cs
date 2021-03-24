using System;

/* It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.

9 = 7 + 2×1^2
15 = 7 + 2×2^2
21 = 3 + 2×3^2
25 = 7 + 2×3^2
27 = 19 + 2×2^2
33 = 31 + 2×1^2

It turns out that the conjecture was false.

What is the smallest odd composite that cannot be written as the sum of a prime and twice a square? */

namespace ProjectEuler
{
    public class Problem46
    {
        public void Solve()
        {
            int n = 1;
            bool found = false;

            while (!found)
            {
                n += 2;
                if (MathFunctions.isPrime(n))
                {
                    continue;
                }

                int count = 0;
                for(int i = 1; 2*i*i < n; i++)
                {
                    if(MathFunctions.isPrime(n - 2 * i * i))
                    {
                        count++;
                        break;
                    }
                }

                if(count != 1)
                {
                    found = true;
                }
            }

            Console.WriteLine(n);
        }
    }
}
