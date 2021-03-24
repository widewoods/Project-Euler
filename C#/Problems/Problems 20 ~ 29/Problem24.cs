using System;
using System.Collections.Generic;

/* A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.
The lexicographic permutations of 0, 1 and 2 are:

012   021   102   120   201   210

What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9? */

namespace ProjectEuler
{
    public class Problem24
    {
        public List<string> Permutate(List<string> digits)
        {
            List<string> returnList = new List<string>();
            if (digits.Count > 2)
            {
                foreach(string str in digits)
                {
                    List<string> newDigits = new List<string>();
                    newDigits.AddRange(digits);
                    newDigits.Remove(str);

                    List<string> permutatedList = new List<string>();
                    permutatedList.AddRange(Permutate(newDigits));

                    foreach(string permutation in permutatedList)
                    {
                        returnList.Add(str + permutation);
                    }
                }
                return returnList;
            }
            else if(digits.Count == 2)
            {
                List<string > permutated = new List<string>() { digits[0] + digits[1], digits[1] + digits[0] };
                return permutated;
            }
            return null;
        }
    }
}
