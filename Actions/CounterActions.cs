using System.Threading;
using System.Threading.Tasks;
using Redux;

namespace blazor_playground.Actions
{
    public class IncrementAction : IAction { }

    public class DecrementAction : IAction { }

    public class IncrementByCount : IAction
    {
        public int Increment { get; }
        public IncrementByCount(int increment)
        {
            this.Increment = increment;
        }
    }

    public class IncrementActionAsync : IAction
    {
        public IncrementActionAsync()
        {
            // simulate a long working process:
            Thread.Sleep(1000);
        }
    }
}