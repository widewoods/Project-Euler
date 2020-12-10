using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Problem12 problem = new Problem12();

            Console.Clear();

            problem.Solve(500);
        }
    }
}