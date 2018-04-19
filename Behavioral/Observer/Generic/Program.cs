using System;
using DesignPatterns.Models;

namespace DesignPatterns.Behavioral.Observer.Generic
{
    public class ConcretePublisher : Publisher<Location>
    {
        public ConcretePublisher() { }

        public void UpdateLocation(Location loc)
        {
            if (loc == null)
                base.PublishError("object null");
            else
                base.PublishUpdate(loc);
        }

        public void StopPublishing()
        {
            base.EndTransmission();
        }
    }

    public class ConcreteObserver : Observer<Location>
    {
        private string _name;
        private int maxMessagesToProcess;
        private int messagesReceived;
        public ConcreteObserver(string name, int messageCount)
        {
            _name = name;
            maxMessagesToProcess = messageCount;
            messagesReceived = 0;
        }

        public override void OnCompleted()
        {
            Console.WriteLine($"The Location Tracker has completed transmitting data to {_name}." + Environment.NewLine);
        }

        public override void OnError(Exception e)
        {
            Console.WriteLine($"{_name}: The location cannot be determined. {e.Message}" + Environment.NewLine);
        }

        public override void OnNext(Location loc)
        {

            Console.WriteLine($"{_name}: The current location is {loc.Latitude}, {loc.Longitude}." + Environment.NewLine);
            if (++messagesReceived == maxMessagesToProcess)
                base.Unsubscribe();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new ConcretePublisher();

            var subscriber1 = new ConcreteObserver("Home123", 3);
            subscriber1.Subscribe(publisher);

            var subscriber2 = new ConcreteObserver("Work123", 1);
            subscriber2.Subscribe(publisher);

            publisher.UpdateLocation(new Location(47.234, -122.14323));
            publisher.UpdateLocation(new Location(38.34543, -125.334));
            publisher.UpdateLocation(new Location(23.3454, -223.23424));
            publisher.UpdateLocation(new Location(53.3334, -199.23424));
            publisher.UpdateLocation(new Location(47.234, -122.14323));

            publisher.StopPublishing();
        }
    }
}
