using System;

//2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

//What is the sum of the digits of the number 2^1000?

namespace ProjectEuler
{
    public class Problem16
    { 
        int[] digits;

        int[] MultiplyByTwo(int[] digits)
        {
            int carry = 0;

            for(int i = digits.Length - 1; i >= 0; i--)
            {
                int multipliedDigit = digits[i] * 2;

                digits[i] = multipliedDigit % 10 + carry;

                if (multipliedDigit >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            return digits;
        }

        public void Solve(int power)
        {
            int numberOfDigits = (int)MathF.Round(power * MathF.Log10(2) - 0.5f) + 1;
            digits = new int[numberOfDigits];

            digits[numberOfDigits - 1] = 1;

            for(int i = 0; i < power; i++)
            {
                digits = MultiplyByTwo(digits);
            }

            string number = "";
            int sumOfDigits = 0;

            foreach(int digit in digits)
            {
                number += digit;
                sumOfDigits += digit;
            }
            Console.WriteLine("2^" + power + " = " + number);
            Console.WriteLine("The sum of digits = " + sumOfDigits);
        }
    }
}
