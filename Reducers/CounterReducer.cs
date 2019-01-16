using blazor_playground.Actions;
using Redux;

namespace blazor_playground.Reducers
{
    public class CounterReducer
    {
        public static int Reduce(int previousState, IAction action)
        {
            if (action is IncrementAction || action is IncrementActionAsync)
            {
                return previousState + 1;
            }
            else if (action is DecrementAction)
            {
                return previousState - 1;
            }
            else if (action is IncrementByCount asyncAction)
            {
                return previousState + asyncAction.Increment;
            }

            return previousState;
        }
    }
}