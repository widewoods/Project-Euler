using System;

/* Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:

1634 = 1^4 + 6^4 + 3^4 + 4^4
8208 = 8^4 + 2^4 + 0^4 + 8^4
9474 = 9^4 + 4^4 + 7^4 + 4^4
As 1 = 1^4 is not a sum it is not included.

The sum of these numbers is 1634 + 8208 + 9474 = 19316.

Find the sum of all the numbers that can be written as the sum of fifth powers of their digits. */

namespace ProjectEuler
{
    public class Problem30
    {
        public void Solve()
        {
            int sum = 0;
            for (int i = 2; i <= 354294; i++)
            {
                int a, b, c, d, e, f;
                f = i % 10;
                e = i / 10 % 10;
                d = i / 100 % 10;
                c = i / 1000 % 10;
                b = i / 10000 % 10;
                a = i / 100000;

                float sumOfPowers = MathF.Pow(f, 5) + MathF.Pow(e, 5) + MathF.Pow(d, 5) + MathF.Pow(c, 5) + MathF.Pow(b, 5) + MathF.Pow(a, 5);

                if (i == sumOfPowers)
                {
                    sum += i;
                }
            }
            Console.Write(sum);
        }
    }
}
