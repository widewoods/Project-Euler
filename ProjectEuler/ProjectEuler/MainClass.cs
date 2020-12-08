using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ProblemNine problemNine = new ProblemNine();

            Console.Clear();

            problemNine.Solve(1000);

        }
    }
}