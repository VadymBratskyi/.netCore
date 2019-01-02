using System;
using System.Collections.Generic;
using System.Text;
using FactoryPatern.Models.Car2.PartsFactory;

namespace FactoryPatern.Models.Car2
{
    public class Tiguan : Car2
    {
        private CarPartsFactory _factory;

        public Tiguan(CarPartsFactory factory)
        {
            _factory = factory;
            Name = "Tiguan";
            Body = "Crossower";
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
