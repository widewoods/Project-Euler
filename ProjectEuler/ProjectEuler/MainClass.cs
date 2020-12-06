using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //ProblemThree problemThree = new ProblemThree();
            ProblemFour problemFour = new ProblemFour();
            Console.Clear();

            //ProblemOne.Solve();
            //ProblemTwo.Solve();
            //problemThree.Solve(600851475143, 2);
            problemFour.Solve();
        }
    }
}
