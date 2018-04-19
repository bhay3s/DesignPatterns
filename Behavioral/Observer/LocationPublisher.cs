using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;

namespace DesignPatterns.Behavioral.Observer
{
    public partial class LocationPublisher : IObservable<Location>
    {
        private List<IObserver<Location>> _observers;

        public LocationPublisher()
        {
            _observers = new List<IObserver<Location>>();
        }

        public IDisposable Subscribe(IObserver<Location> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        public void TrackLocation(Location location)
        {
            foreach (var observer in _observers.ToArray())
            {
                //todo: handle error in location - send to 
                //observer?.OnError(new Exception(""));
                observer?.OnNext(location);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in _observers.ToArray())
                observer?.OnCompleted();

            _observers.Clear();
        }
    }
}
