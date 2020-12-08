using System;
using System.Collections.Generic;

//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

namespace ProjectEuler
{
    public class ProblemNine
    {
        List<int[]> pythagoreanTriplets = new List<int[]>();

        public void Solve(int sumOfTriplet)
        {
            for(int a  = 3; a < sumOfTriplet; a++)
            {
                for(int b = a + 1; b < sumOfTriplet - 1 - a; b++)
                {
                    int c = sumOfTriplet - a - b;
                    if(a*a + b*b == c * c)
                    {
                        Console.WriteLine("The pythagorean triplet with sum " + sumOfTriplet + " is " + a + " " + b + " " + c);
                    }
                }
            }
        }
    }
}
