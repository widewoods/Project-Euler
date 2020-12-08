using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class ProblemNine
    {
        List<int[]> pythagoreanTriplets = new List<int[]>();

        public void Solve(int sumOfTriplet)
        {
            int a = 1, b = 2, c = 3;

            for(c = 3; a+b+c <= sumOfTriplet; c++)
            {
                for(b = 2; b < c; b++)
                {
                    for(a = 1; a < b; a++)
                    {
                        if(MathF.Pow(a, 2) + MathF.Pow(b, 2) == MathF.Pow(c, 2))
                        {
                            pythagoreanTriplets.Add(new int[] { a, b, c });
                            if(a + b + c == sumOfTriplet)
                            {
                                Console.WriteLine("The pythagorean triplet with sum " + sumOfTriplet + " is " + a + " " + b + " " + c);
                            }
                        }
                    }
                }
                b = 2;
                a = 1;
            }
        }
    }
}
