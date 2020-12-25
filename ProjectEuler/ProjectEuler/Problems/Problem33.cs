using System;

/* The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it 
may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.

We shall consider fractions like, 30/50 = 3/5, to be trivial examples.

There are exactly four non-trivial examples of this type of fraction, less than one in value,
and containing two digits in the numerator and denominator.

If the product of these four fractions is given in its lowest common terms, find the value of the denominator. */

namespace ProjectEuler
{
    public class Problem33
    {
        int[] i_digits = new int[2];
        int[] j_digits = new int[2];

        public void Solve()
        {
            float product = 1;
            for (int i = 10; i < 100; i++)
            {
                i_digits[0] = i / 10;
                i_digits[1] = i % 10;
                for(int j = 10; j < i; j++)
                {
                    j_digits[0] = j / 10;
                    j_digits[1] = j % 10;

                    if(i % 10 != 0 && j % 10 != 0)
                    {
                        if((float)j / i == CancelSameNumber())
                        {
                            product *= (float)j / i;
                        }
                    }
                }
            }

            Console.Write(product);
        }

        float CancelSameNumber()
        {
            for(int a = 0; a < 2; a++)
            {
                for(int b = 0; b < 2; b++)
                {
                    if(j_digits[a] == i_digits[b])
                    {
                        switch((a, b))
                        {
                            case (0, 0):
                                return (float)j_digits[1] / i_digits[1];
                            case (0, 1):
                                return (float)j_digits[1] / i_digits[0];
                            case (1, 0):
                                return (float)j_digits[0] / i_digits[1];
                            case (1, 1):
                                return (float)j_digits[0] / i_digits[0];
                        }
                    }
                }
            }

            return 0;
        }
    }
}
