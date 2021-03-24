using System;
using System.Collections.Generic;

/*  If the numbers 1 to 5 are written out in words: one, two, three, four, five, 
then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?


NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters
and 115 (one hundred and fifteen) contains 20 letters.
The use of "and" when writing out numbers is in compliance with British usage. */

namespace ProjectEuler
{
    public class Problem17
    {
        Dictionary<int, string> numberWord = new Dictionary<int, string>();
        string[] numberStrings = new string[1001];

        public void Solve()
        {
            numberStrings[0] = "";
            numberWord.Add(0, "");

            numberWord.Add(1, "one");
            numberWord.Add(2, "two");
            numberWord.Add(3, "three");
            numberWord.Add(4, "four");
            numberWord.Add(5, "five");
            numberWord.Add(6, "six");
            numberWord.Add(7, "seven");
            numberWord.Add(8, "eight");
            numberWord.Add(9, "nine");

            numberWord.Add(10, "ten");
            numberWord.Add(11, "eleven");
            numberWord.Add(12, "twelve");
            numberWord.Add(13, "thirteen");
            numberWord.Add(14, "fourteen");
            numberWord.Add(15, "fifteen");
            numberWord.Add(16, "sixteen");
            numberWord.Add(17, "seventeen");
            numberWord.Add(18, "eighteen");
            numberWord.Add(19, "nineteen");

            numberWord.Add(20, "twenty");
            numberWord.Add(30, "thirty");
            numberWord.Add(40, "forty");
            numberWord.Add(50, "fifty");
            numberWord.Add(60, "sixty");
            numberWord.Add(70, "seventy");
            numberWord.Add(80, "eighty");
            numberWord.Add(90, "ninety");

            for(int i = 1; i <= 9; i++)
            {
                numberWord.Add(100 * i, numberWord[i] + " hundred");
            }

            numberWord.Add(1000, "one thousand");

            for(int i = 1; i <= 1000; i++)
            {
                int hundreds = i / 100 * 100;
                int tens = i / 10 % 10 * 10;
                int ones = i % 10;


                if(i < 20 && i >= 10)
                {
                    numberStrings[i] = numberWord[i];
                }
                else if(hundreds == 1000)
                {
                    numberStrings[i] = numberWord[1000];
                }
                else if(hundreds >= 100 && tens == 0 && ones == 0) 
                {
                    numberStrings[i] = numberWord[i];
                }
                else if(hundreds >= 100 && tens == 10)
                {
                    numberStrings[i] = numberWord[hundreds] + " and " + numberWord[tens + ones];
                }
                else if (hundreds >= 100)
                {
                    numberStrings[i] = numberWord[hundreds] + " and " + numberWord[tens] + numberWord[ones];
                }
                else if(ones == 0)
                {
                    numberStrings[i] = numberWord[tens];
                }
                else if(tens == 0)
                {
                    numberStrings[i] = numberWord[ones];
                }
                else
                {
                    numberStrings[i] = numberWord[tens] + " " + numberWord[ones];
                }
            }

            int sum = 0;
            foreach(string number in numberStrings)
            {
                sum += number.Replace(" ", "").Length;
            }
            Console.WriteLine(sum);
        }
    }
}
