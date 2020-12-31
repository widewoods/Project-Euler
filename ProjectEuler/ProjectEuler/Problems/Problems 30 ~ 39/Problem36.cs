using System;
using System.Collections.Generic;

/* The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.

Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.

(Please note that the palindromic number, in either base, may not include leading zeros.) */

namespace ProjectEuler
{
    public class Problem36
    {
        List<int> palindromicInDecimal = new List<int>();
        public void Solve()
        {
            for(int i = 1; i < 1000000; i++)
            {
                if (isPalindromic(i.ToString()))
                {
                    palindromicInDecimal.Add(i);
                }
            }

            int sum = 0;
            foreach(int p in palindromicInDecimal)
            {
                string binary = ConvertToBinary(p);
                if (isPalindromic(binary))
                {
                    sum += p;
                }
            }

            Console.WriteLine(sum);
        }

        bool isPalindromic(string number)
        {
            char[] charArray = number.ToCharArray();

            int count = 0;
            for(int i = 0; i < MathF.Round(charArray.Length/2); i++)
            {
                if(charArray[i] == charArray[charArray.Length - 1 - i])
                {
                    count++;
                }
                else
                {
                    return false;
                }
            }

            if (count == MathF.Round(charArray.Length / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        string ConvertToBinary(int num)
        {
            string binary = string.Empty;

            const int mask = 1;

            while(num > 0)
            {
                binary = (num & mask) + binary;
                num = num >> 1;
            }

            return binary;
        }
    }
}
