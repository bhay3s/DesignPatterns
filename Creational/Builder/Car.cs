using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public Car(Builder builder)
        {
            _ = builder ?? throw new Exception("Builder is null.");
            this.Make = builder.GetMake() ?? throw new Exception("Missing CarBuilder Make");
            this.Model = builder.GetModel(); // required items throw exceptions if not set
            this.Color = builder.GetColor();
            this.Engine = builder.GetEngine();
        }

        public static Builder NewBuilder => new Builder();

        public class Builder
        {
            private string _make { get; set; }
            private string _model { get; set; }
            private string _color { get; set; }
            private string _engine { get; set; }

            public Builder() { }

            public Builder SetMake(string make) { _make = make; return this; }
            public string GetMake() { return _make; }
            public Builder SetModel(string model) { _model = model; return this; }
            public string GetModel() { return _model; }
            public Builder SetColor(string color) { _color = color; return this; }
            public string GetColor() { return _color; }
            public Builder SetEngine(string engine) { _engine = engine; return this; }
            public string GetEngine() { return _engine; }
            public Car Build() { return new Car(this); }
        }
    }
}
