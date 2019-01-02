using FactoryPatern.Models.Car2.PartsFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatern.Models.Car2
{
    public class Passat : Car2
    {
        private CarPartsFactory _factory;

        public Passat(CarPartsFactory factory)
        {
            _factory = factory;
            Name = "Passat";
            Body = "Sedan";
        }

        public override string Configure()
        {
            Engine = _factory.CreateEngine();
            PaintColor = _factory.CreatePaint();
            Wheels = _factory.CreateWheels();

            return $"Configuring: {Name}; " +
                   $"Body is: {Body}; " +
                   $"Engine is: {Engine.GetEngineType()}; " +
                   $"PaintColor is: {PaintColor.GetColor()}; " +
                   $"Wheels are {Wheels.GetTypeWheels()};";
        }
    }
}
