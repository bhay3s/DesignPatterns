using System;
using DesignPatterns.Models;

namespace DesignPatterns.Behavioral.Observer
{
    public class LocationObserver : IObserver<Location>, IDisposable
    {
        private IDisposable unsubscriber;
        private string _observerName;

        public string Name => _observerName;

        public LocationObserver(string name)
        {
            this._observerName = name;
        }

        public virtual void Subscribe(IObservable<Location> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine($"The Location Tracker has completed transmitting data to {this.Name}." + Environment.NewLine);
            Unsubscribe();
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine($"{Name}: The location cannot be determined." + Environment.NewLine);
        }

        public virtual void OnNext(Location loc)
        {
            Console.WriteLine($"{Name}: The current location is {loc.Latitude}, {loc.Longitude}." + Environment.NewLine);
        }

        public virtual void Unsubscribe()
        {
            Console.WriteLine($"{Name}: Unsubscribing from updates." + Environment.NewLine);
            unsubscriber.Dispose();
        }

        public void Dispose()
        {
            Unsubscribe();
        }
    }
}
