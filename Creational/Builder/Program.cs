using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = Car.NewBuilder
                .SetMake("Ford")
                .SetModel("Mustang")
                .SetColor("Red")
                .SetEngine("v8")
                .Build();

            Console.WriteLine($"Make: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Color: {car.Color}");
            Console.WriteLine($"Engine: {car.Engine}");

            //***********************************************
            
            var builder = new Car.Builder();
            builder.SetMake("Chevy");
            builder.SetModel("Corvette");
            builder.SetColor("blue");
            builder.SetEngine("v6");

            Car car2 = new Car(builder);

            Console.WriteLine($"Make: {car2.Make}");
            Console.WriteLine($"Model: {car2.Model}");
            Console.WriteLine($"Color: {car2.Color}");
            Console.WriteLine($"Engine: {car2.Engine}");
        }
    }
}
