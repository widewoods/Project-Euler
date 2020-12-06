using System;

//Find the difference between the sum of the squares of the 
//first one hundred natural numbers and the square of the sum.

namespace ProjectEuler
{
    public class ProblemSix
    {
        public void Solve()
        {
            int n = 100;

            int SumOfSquares = SumOfSquaresFromOneToN(n);

            int SumOfNumbers = SumOfNumbersFromOneToN(n);

            int answer = (int)MathF.Abs(MathF.Pow(SumOfNumbers, 2) - SumOfSquares);

            Console.WriteLine(answer);
        }

        int SumOfNumbersFromOneToN(int num)
        {
            int n = num;

            return n * (n + 1) / 2;
        }

        int SumOfSquaresFromOneToN(int num)
        {
            int n = num;

            return n * (n + 1) * (2 * n + 1) / 6;
        }
    }
}
