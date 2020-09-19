using System;
using System.Collections.Generic;
using System.Text;

namespace pattern_state
{
    public class TheProblem
    {
        public IState CustomState { get; set; }

        public TheProblem()
        {
            // initial solucion is the A
            this.CustomState = new SolutionA();
        }

        public TheProblem(IState Solution)
        {
            // set the solucion by dependency inject
            this.CustomState = Solution;
        }

        public void ChangeState(IState state)
        {
            this.CustomState = state;
        }

    }

    public class SolutionA : IState
    {

        public void Handle()
        {
            Console.WriteLine("Solution A.");
        }
    }
    public class SolutionB : IState
    {
        public void Handle()
        {
            Console.WriteLine("Solution B.");
        }
    }

    public interface IState
    {
        void Handle();
    }
}
