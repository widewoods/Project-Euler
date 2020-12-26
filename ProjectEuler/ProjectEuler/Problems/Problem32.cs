using System;
using System.Collections.Generic;

/* We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; 
for example, the 5-digit number, 15234, is 1 through 5 pandigital.

The product 7254 is unusual, as the identity, 39 × 186 = 7254,
containing multiplicand, multiplier, and product is 1 through 9 pandigital.

Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.

HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum. */

namespace ProjectEuler
{
    public class Problem32
    {
        List<string> set = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        List<int> pandigitalNums = new List<int>();

        public void Solve()
        {
            int multiplicand, multiplier, product;
            int sum = 0;

            List<string> permutations = MathFunctions.Permutate(set);

            foreach (string p in permutations)
            {
                product = int.Parse(p.Substring(5));

                //2 digit * 3 digit = 4 digit
                multiplicand = int.Parse(p.Substring(0, 2));
                multiplier = int.Parse(p.Substring(2, 3));

                if(multiplicand * multiplier == product && !pandigitalNums.Contains(product))
                {
                    sum += product;
                    pandigitalNums.Add(product);
                }

                //1 digit * 4 digit = 4 digit
                multiplicand = int.Parse(p.Substring(0, 1));
                multiplier = int.Parse(p.Substring(1, 4));

                if (multiplicand * multiplier == product && !pandigitalNums.Contains(product))
                {
                    sum += product;
                    pandigitalNums.Add(product);
                }
            }

            Console.Write(sum);
        }
    }
}
