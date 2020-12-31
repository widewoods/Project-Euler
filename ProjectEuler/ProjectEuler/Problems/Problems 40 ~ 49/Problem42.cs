using System;
using System.Collections.Generic;

/* The nth term of the sequence of triangle numbers is given by, t(n) = ½n(n+1); so the first ten triangle numbers are:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

By converting each letter in a word to a number corresponding to its alphabetical position
and adding these values we form a word value.
For example, the word value for SKY is 19 + 11 + 25 = 55 = t(10).
If the word value is a triangle number then we shall call the word a triangle word.

Using words.txt (right click and 'Save Link/Target As...'),
a 16K text file containing nearly two-thousand common English words, how many are triangle words? */

namespace ProjectEuler
{
    public class Problem42
    {
        List<int> triangleNumbers = new List<int>();

        public void Solve(string[] text)
        {
            GetTriangleNumbers(500);

            int count = 0;
            foreach (string word in text)
            {
                int wordValue = 0;
                foreach(char c in word.ToCharArray())
                {
                    wordValue += c - 64;
                }

                if (triangleNumbers.Contains(wordValue))
                {
                    count++;
                }
            }

            Console.Write(count);
        }

        void GetTriangleNumbers(int limit)
        {
            int n = 1;
            while(n * (n + 1) / 2 <= limit)
            {
                triangleNumbers.Add(n * (n + 1) / 2);
                n++;
            }
        }
    }
}
