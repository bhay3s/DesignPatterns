using System;
namespace DesignPatterns.Models
{
    public class Location
    {
        private double lat, lon;

        public Location(double latitude, double longitude)
        {
            this.lat = latitude;
            this.lon = longitude;
        }

        public double Latitude => lat;
        public double Longitude => lon;
    }
}
