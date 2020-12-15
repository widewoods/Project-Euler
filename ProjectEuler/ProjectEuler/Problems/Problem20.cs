using System;
using System.Collections.Generic;

/* n! means n × (n − 1) × ... × 3 × 2 × 1

For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

Find the sum of the digits in the number 100! */

namespace ProjectEuler
{
    public class Problem20
    {
        List<int> bigNumber = new List<int>() { 1 };
        List<int> products = new List<int>();
        int[] number = new int[200];
        int currentDigit = 0;
        int carry = 0;

        //Multiplier has to be less than 112: 112 * 9 > 1000
        void MultiplyWithBigNumber(List<int> number, int multiplier)
        {
            int product;

            products.Clear();

            for (int i = number.Count - 1; i >= 0; i--)
            {
                product = number[i] * multiplier;

                products.Add(product);
        //Couldn't make a factorial function work myself, so I found a solution from https://jaykaychoi.tistory.com/64
        //Used solution once I understood it fully.

                number[i] = product % 10;
            }

            number.Clear();

            if(products.Count == 1)
            {
                number.Insert(0, products[0] % 10);
                if(products[0] >= 10)
                {
                    number.Insert(0, products[0] / 10 % 10);
                }
            }
            else if(products.Count == 2)
            {
                number.Insert(0, products[0] % 10);
                if(products[0] / 10 % 10 + products[1] % 10 != 0)
                {
                    number.Insert(0, products[0] / 10 % 10 + products[1] % 10);
                }
                if(products[1] / 10 % 10 != 0)
                {
                    number.Insert(0, products[1] / 10 % 10);
                }
            }
            else
        void Factorial(int n)
        {
            number[0] = 1;
            for (int i = 2; i <= n; i++)
            {
                number.Insert(0, products[0] % 10);
                number.Insert(0, products[0] / 10 % 10 + products[1] % 10);
                for (int i = 0; i < products.Count - 2; i++)
                {
                    number.Insert(0, products[i] / 100 + products[i + 1] / 10 % 10 + products[i + 2] % 10);
                }
                if(products[products.Count - 2] / 100 + products[products.Count - 1] / 10 % 10 != 0)
                {
                    number.Insert(0, products[products.Count - 2] / 100 + products[products.Count - 1] / 10 % 10);
                }
                if(products[products.Count - 1] / 100 != 0)
                for (int j = 0; j <= currentDigit; j++)
                {
                    number.Insert(0, products[products.Count - 1] / 100);
                }
            }
                    number[j] = number[j] * i + carry;
                    carry = 0;

            for(int i = number.Count - 1; i >= 0; i--)
            {
                if(number[i] >= 10)
                {
                    if(i != 0)
                    if (number[j] >= 10)
                    {
                        number[i - 1] += number[i] / 10;
                        number[i] = number[i] % 10;
                    }
                    else
                    {
                        number.Insert(0, number[i] / 10);
                        number[i] = number[i] % 10;
                        carry = number[j] / 10;
                        number[j] = number[j] % 10;

                        //We know digit goes up by one when biggest digit * i >= 10
                        if (j == currentDigit)
                        {
                            currentDigit++;
                        }
                    }
                }
            }
        }


        void Factorial(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                MultiplyWithBigNumber(bigNumber, i);
            }
        }

        public void Solve(int n)
        {
            Factorial(n);

            int sum = 0;

            foreach(int digit in bigNumber)
            foreach (int digit in number)
            {
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
