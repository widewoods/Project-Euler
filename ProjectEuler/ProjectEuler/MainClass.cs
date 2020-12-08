using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ProblemTen problem = new ProblemTen();

            Console.Clear();

            problem.Solve(2000000);

        }
    }
}