using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ProblemSeven problem = new ProblemSeven();

            Console.Clear();

            problem.Solve(10001);
        }
    }
}