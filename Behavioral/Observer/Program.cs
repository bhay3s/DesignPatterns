using DesignPatterns.Models;

namespace DesignPatterns.Behavioral.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a publisher and two observers
            var publisher = new LocationPublisher();

            var subscriber1 = new LocationObserver("Home");
            subscriber1.Subscribe(publisher);

            var subscriber2 = new LocationObserver("Work");
            subscriber2.Subscribe(publisher);

            var subscriber3 = new LocationObserver("Other");
            subscriber3.Subscribe(publisher);


            publisher.TrackLocation(new Location(47.234, -122.14323));
            publisher.TrackLocation(new Location(38.34543, -125.334));

            subscriber1.Unsubscribe();

            publisher.TrackLocation(new Location(23.3454, -223.23424));
            publisher.TrackLocation(new Location(53.3334, -199.23424));

            publisher.EndTransmission();
        }
    }
}
