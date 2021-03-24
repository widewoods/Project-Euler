using System;

//A palindromic number reads the same both ways.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace ProjectEuler
{
    public class Problem4
    {

        public void Solve()
        {
            int largestPalindrome = 0;

            for(int i = 999; i >= 100; i--)
            {
                for(int j = 999; j >= 100; j--)
                {
                    if(isPalindrome(i * j))
                    {
                        if(largestPalindrome == 0)
                        {
                            largestPalindrome = i * j;
                        }
                        if(largestPalindrome < i * j)
                        {
                            largestPalindrome = i * j;
                        }
                    }
                }
            }

            Console.Write("The largest palindrome is " + largestPalindrome);
        }

        public bool isPalindrome(int num)
        {
            char[] numArray = num.ToString().ToCharArray();

            int numLength = numArray.Length;

            int count = 0;

            for(int i = 0; i < MathF.Round(numLength/2); i++)
            {
                if(numArray[i] == numArray[numArray.Length - 1 - i])
                {
                    count++;
                }
                else
                {
                    return false;
                }
            }

            if(count == MathF.Round(numLength / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
