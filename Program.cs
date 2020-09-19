using System;

namespace pattern_state
{
    class Program
    {
        static void Main(string[] args)
        {
            // run any example
            ExampleOne();
            // ExampleTwo();
            Console.ReadLine();
        }

        static void ExampleOne()
        {
            var context = new TheProblem();
            context.CustomState.Handle();
            context.ChangeState(new SolutionB());
            context.CustomState.Handle();
            
        }

        static void ExampleTwo()
        {
            var context = new TheProblem(new SolutionB());
            context.CustomState.Handle();
            context.ChangeState(new SolutionA());
            context.CustomState.Handle();
        }

    }
}
