using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ProblemThree problemThree = new ProblemThree();
            Console.Clear();

            //ProblemOne.Solve();
            //ProblemTwo.Solve();
            problemThree.Solve(600851475143, 2);
        }
    }
}
