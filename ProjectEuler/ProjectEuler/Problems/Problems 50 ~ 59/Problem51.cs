using System;
using System.Linq;

//Problem: https://projecteuler.net/problem=51

namespace ProjectEuler
{
    public class Problem51
    {
        public void Solve()
        {
            int target = 8;
            bool found = false;
            int i = 0;
            while (!found)
            {
                int lastDigit = i % 10;
                int numLength = (int)MathF.Floor(MathF.Log10(i)) + 1;

                int[] digitsToReplace;

                for (int j = 1; j < numLength; j++)
                {
                    digitsToReplace = new int[j];
                    for(int k = 1; k <= numLength - j; k++)
                    {
                        for(int a = 0; a < j; a++)
                        {
                            digitsToReplace[a] = k + a;

                            int count = 0;
                            if (lastDigit == 1 || lastDigit == 3 || lastDigit == 7 || lastDigit == 9)
                            {
                                int[] replacements = GetReplacements(i, digitsToReplace);
                                foreach (int n in replacements)
                                {
                                    if (MathFunctions.isPrime(n))
                                    {
                                        count++;
                                    }
                                }
                                if (count == target)
                                {
                                    Console.WriteLine(i);
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }
                }

                i++;
            }
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
