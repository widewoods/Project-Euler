using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Problem7 problem = new Problem7();

            Console.Clear();

            problem.Solve(10001);
        }
    }
}