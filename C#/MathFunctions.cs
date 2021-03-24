using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class MathFunctions
    {
        public static bool isPrime(int num)
        {
            if (num == 1)
            {
                return false;
            }
            else if (num < 4)
            {
                return true;
            }
            else if (num % 2 == 0)
            {
                return false;
            }
            else if (num < 9)
            {
                return true;
            }
            else if (num % 3 == 0)
            {
                return false;
            }
            else
            {
                int r = (int)MathF.Round((float)Math.Sqrt(num) + 0.5f);
                int f = 5;

                while (f <= r)
                {
                    if (num % f == 0)
                    {
                        return false;
                    }
                    if (num % (f + 2) == 0)
                    {
                        return false;
                    }

                    f = f + 6;
                }
            }
            return true;
        }

        public static List<int> GetPrimesUnderLimit(int limit)
        {
            int count = 1;
            int candidate = 1;
            List<int> primes = new List<int>() { 2 };

            while (candidate < limit)
            {
                candidate = candidate + 2;
                if (isPrime(candidate))
                {
                    count++;
                    primes.Add(candidate);
                }
            }

            return primes;
        }

        public static List<int> LargePower(int @base, int exponent)
        {
            List<int> digits = new List<int>() { 1 };
            int carry = 0;
            int product;

            for(int i = 0; i < exponent; i++)
            {
                int digitCount = digits.Count;
                for(int j = 0; j < digitCount; j++)
                {
                    product = digits[j] * @base + carry;

                    int temp = product % 10;
                    if(j == digitCount - 1)
                    {
                        while (product >= 10)
                        {
                            digits.Add(product / 10 % 10);
                            product = product / 10;
                        }
                    }
                    carry = product / 10;
                    digits[j] = temp;
                }
                carry = 0;
            }

            return digits;
        }

        public static List<string> Permutate(List<string> digits)
        {
            List<string> returnList = new List<string>();
            if (digits.Count > 2)
            {
                foreach (string str in digits)
                {
                    List<string> newDigits = new List<string>();
                    newDigits.AddRange(digits);
                    newDigits.Remove(str);

                    List<string> permutatedList = new List<string>();
                    permutatedList.AddRange(Permutate(newDigits));

                    foreach (string permutation in permutatedList)
                    {
                        returnList.Add(str + permutation);
                    }
                }
                return returnList;
            }
            else if (digits.Count == 2)
            {
                List<string> permutated = new List<string>() { digits[0] + digits[1], digits[1] + digits[0] };
                return permutated;
            }
            return null;
        }

        public static int Factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }

            int factorial = 1;

            for(int i = n; i >= 2; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int[] IntToDigitArray(int num)
        {
            int digitCount = (int)MathF.Floor(MathF.Log10(num)) + 1;
            int[] digits = new int[digitCount];

            for(int i = 0; i < digitCount; i++)
            {
                digits[i] = num % 10;
                if(num > 9)
                {
                    num = num / 10;
                }
            }

            return digits;
        }

        //Greatest Common Divisor, from https://stackoverflow.com/questions/18541832/c-sharp-find-the-greatest-common-divisor
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }

        public static List<int> AddLargeInt(List<int> a, List<int> b)
        {
            List<int> sumList = new List<int>();
            while(a.Count != b.Count)
            {
                if(a.Count > b.Count)
                {
                    b.Add(0);
                }
                else
                {
                    a.Add(0);
                }
            }

            int carry = 0;
            for(int i = 0; i < a.Count; i++)
            {
                int sum = a[i] + b[i] + carry;
                if(sum >= 10)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                sumList.Add(sum % 10);
            }
            if(carry == 1)
            {
                sumList.Add(1);
            }

            return sumList;
        }
    }
}
