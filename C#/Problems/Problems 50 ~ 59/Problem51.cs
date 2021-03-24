using System;
using System.Linq;
using System.Collections.Generic;

//Problem: https://projecteuler.net/problem=51

namespace ProjectEuler
{
    public class Problem51
    {
        public void Solve()
        {
            int target = 7;
            bool found = false;
            int i = 11;
            
            while (!found)
            {
                int lastDigit = i % 10;
                int numLength = (int)MathF.Floor(MathF.Log10(i)) + 1;

                i += 2;
            }

            //if (lastDigit == 1 || lastDigit == 3 || lastDigit == 7 || lastDigit == 9)
            //{
            //    int count = 0;

            //    int[] replacements = GetReplacements(i, digitsToReplace);

            //    foreach (int n in replacements)
            //    {
            //        if (MathFunctions.isPrime(n))
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == target)
            //    {
            //        Console.WriteLine(i);
            //        found = true;
            //        break;
            //    }
            //}
        }

        private int[] GetReplacements(int number, int[] digitsToReplace)
        {
            int[] digitArray = MathFunctions.IntToDigitArray(number);
            int[] replacedNumbers;
            int k = 0;
            if(digitsToReplace.Max() == digitArray.Length - 1)
            {
                replacedNumbers = new int[9];
                k = 1;
            }
            else
            {
                replacedNumbers = new int[10];
            }

            for(int i = k; i < 10; i++)
            {
                foreach(int n in digitsToReplace)
                {
                    digitArray[n] = i; 
                }
                replacedNumbers[i - k] = DigitArrayToInt(digitArray);
            }

            return replacedNumbers;
        }

        private int DigitArrayToInt(int[] digitArray)
        {
            int value = 0;
            for(int i = 0; i < digitArray.Length; i++)
            {
                value += digitArray[i] * (int)MathF.Pow(10, i);
            }

            return value;
        }
    }
}
