using System;

//Problem:L What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

namespace ProjectEuler
{
    public class ProblemFive
    {
        public void Solve()
        {
            int commonMultiple = 1;

            for (int i = 2; i <= 20; i++)
            {
                commonMultiple = FindLeastCommonMultiple(commonMultiple, i);
            }

            Console.WriteLine(commonMultiple);
        }

        int FindLeastCommonMultiple(int num1, int num2)
        {
            int leastCommonMultiple = 0;

            for(int i = 1; i <= num2; i++)
            {
                for (int j = 1; j <= num1; j++)
                {
                    if(num1 * i == num2 * j)
                    {
                        leastCommonMultiple = num1 * i;
                        return leastCommonMultiple;
                    }
                }
            }
            return leastCommonMultiple;
        }
    }
}
