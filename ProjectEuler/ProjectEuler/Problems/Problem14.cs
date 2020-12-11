using System;
using System.Collections.Generic;

/* The following iterative sequence is defined for the set of positive integers:

n → n/2 (n is even)
n → 3n + 1 (n is odd)

Using the rule above and starting with 13, we generate the following sequence:

13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet
(Collatz Problem), it is thought that all starting numbers finish at 1.

Which starting number, under one million, produces the longest chain?

NOTE: Once the chain starts the terms are allowed to go above one million. */

namespace ProjectEuler
{
    public class Problem14
    {
        //Key is starting number, Value is the steps from the number
        private Dictionary<long, int> startingNumberStepPair = new Dictionary<long, int>();

        long StepCollatzSequence(long num)
        {
            if(num % 2 == 0)
            {
                return num / 2;
            }
            else
            {
                return 3 * num + 1;
            }
        }

        long CountSteps(long startingNum)
        {
            if (startingNumberStepPair.ContainsKey(startingNum))
            {
                return startingNumberStepPair[startingNum];
            }
            long n = startingNum;
            int count = 0;

            while(n > 1)
            {
                if (startingNumberStepPair.ContainsKey(n))
                {
                    count = startingNumberStepPair[n] + count;
                    startingNumberStepPair.Add(startingNum, count);
                    return count;
                }

                n = StepCollatzSequence(n);
                count++;
            }

            count++;

            startingNumberStepPair.Add(startingNum, count);
            return count;
        }


        public void FindStartNumWithLargestSteps(int limit)
        { 
            int largestStepCount = 0;
            int startingNumOfLargestStep = 0;

            for(int i = 1; i <= limit; i++)
            {
                long steps = CountSteps(i);

                for(int j = 1; i * MathF.Pow(2, j) <= limit; j++)
                {
                    if(!startingNumberStepPair.ContainsKey(i * (int)MathF.Pow(2, j)))
                    {
                        startingNumberStepPair.Add(i * (int)MathF.Pow(2, j), (int)steps + j);
                    }
                    
                }
            }

            foreach(KeyValuePair<long, int> keyValuePair in startingNumberStepPair)
            {
                if(keyValuePair.Value > largestStepCount)
                {
                    largestStepCount = keyValuePair.Value;
                    startingNumOfLargestStep = (int)keyValuePair.Key;
                }
            }

            Console.WriteLine(startingNumOfLargestStep + " has the largest step count");
        }
    }
}
