using System;
using blazor_playground.Reducers;
using Redux;

namespace blazor_playground.Store
{
    public class CounterStore : IStore<int>
    {
        private IStore<int> _store;

        public CounterStore()
        {
            _store = new Store<int>(CounterReducer.Reduce, 0);
        }

        public IAction Dispatch(IAction action) => _store.Dispatch(action);

        public int GetState() => _store.GetState();

        public IDisposable Subscribe(IObserver<int> observer) => _store.Subscribe(observer);
    }
}