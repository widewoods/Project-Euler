using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Problem11 problem = new Problem11();

            Console.Clear();

            problem.Solve(4, 20);
        }
    }
}