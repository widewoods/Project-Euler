﻿using System;
using System.Collections.Generic;

//Problem: Find the sum of all the multiples of 3 or 5 below 1000.

namespace ProjectEuler
{
    class ProblemOne
    {
        static void Main(string[] args)
        {
            List<int> numbersToAdd = new List<int>();
            int sumOfNumbers = 0;

            for (int i = 1; i < 1000; i++)
            {
                if((i % 3) == 0 || (i % 5) == 0)
                {
                    numbersToAdd.Add(i);
                }
            }

            foreach(int num in numbersToAdd)
            {
                sumOfNumbers += num;
            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}
