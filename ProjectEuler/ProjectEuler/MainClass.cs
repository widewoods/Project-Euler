using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ProblemSeven problemSeven = new ProblemSeven();

            Console.Clear();

            problemSeven.Solve(10001);
        }
    }
}

