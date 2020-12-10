using System;
using System.Collections.Generic;

//Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.

namespace ProjectEuler
{
    public class Problem13
    {
        public void Solve(string numbers)
        {
            int sum = 0;
            List<int> digits = new List<int>();
            string[] slicedNumbers = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for(int i = 49; i >= 0; i--)
            {
                if (i <= 48)
                {
                    sum = sum / 10;
                }

                foreach (string number in slicedNumbers)
                {
                    sum += (int)Char.GetNumericValue(number[i]);
                }
                digits.Insert(0, sum % 10);
            }

            digits.Insert(0, sum / 10 % 10);
            digits.Insert(0, sum / 100);

            string firstTenDigits = "";
            for(int i = 0; i < 10; i++)
            {
                firstTenDigits += digits[i].ToString();
            }

            Console.WriteLine(firstTenDigits);
        }
    }
}
