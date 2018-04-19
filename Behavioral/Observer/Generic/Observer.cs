using System;

namespace DesignPatterns.Behavioral.Observer.Generic
{
    public abstract class Observer<T> : IObserver<T>, IDisposable
    {
        private IDisposable unsubscriber;

        public Observer() { }

        public virtual void Subscribe(IObservable<T> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public abstract void OnCompleted();

        public abstract void OnError(Exception e);

        public abstract void OnNext(T loc);

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public virtual void Dispose()
        {
            Unsubscribe();
        }
    }
}
