using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer.Generic
{
    public abstract class Publisher<T> : IObservable<T>
    {
        private List<IObserver<T>> _observers;

        public Publisher()
        {
            _observers = new List<IObserver<T>>();
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber<T>(_observers, observer);
        }

        protected void PublishUpdate(T obj)
        {
            foreach (var observer in _observers.ToArray())
                observer?.OnNext(obj);
        }

        protected void PublishError(string message)
        {
            foreach (var observer in _observers.ToArray())
                observer?.OnError(new Exception(message));
        }

        protected void EndTransmission()
        {
            foreach (var observer in _observers.ToArray())
                observer?.OnCompleted();
            _observers.Clear();
        }
    }
}
