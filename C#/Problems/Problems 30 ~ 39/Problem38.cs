﻿using System;
using System.Collections.Generic;

/* Take the number 192 and multiply it by each of 1, 2, and 3:

192 × 1 = 192
192 × 2 = 384
192 × 3 = 576
By concatenating each product we get the 1 to 9 pandigital, 192384576.
We will call 192384576 the concatenated product of 192 and (1,2,3)

The same can be achieved by starting with 9 and multiplying by 1, 2, 3, 4, and 5,
giving the pandigital, 918273645, which is the concatenated product of 9 and (1,2,3,4,5).

What is the largest 1 to 9 pandigital 9-digit number that can be formed
as the concatenated product of an integer with (1,2, ... , n) where n > 1? */

namespace ProjectEuler
{
    public class Problem38
    {
        public void Solve()
        {
            int largestPandigital = 0;

            for(int i = 1; i < 10000; i++)
            {
                string concatennatedNum = string.Empty;
                int n = 1;

                while(concatennatedNum.Length < 9)
                {
                    concatennatedNum = concatennatedNum + (i * n).ToString();
                    n++;
                }

                if(concatennatedNum.Length == 9 && isPandigital(concatennatedNum))
                {
                    if(int.Parse(concatennatedNum) > largestPandigital)
                    {
                        largestPandigital = int.Parse(concatennatedNum);
                    }
                }
            }

            Console.Write(largestPandigital);
        }

        bool isPandigital(string number)
        {
            List<char> numberList = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            char[] numberChars = number.ToCharArray();

            foreach(char c in numberChars)
            {
                if (numberList.Contains(c))
                {
                    numberList.Remove(c);
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
