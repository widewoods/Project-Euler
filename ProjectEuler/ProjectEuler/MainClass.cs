using System;
namespace ProjectEuler
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Problem14 problem = new Problem14();

            Console.Clear();

            problem.FindStartNumWithLargestSteps(1000000);
        }
    }
}