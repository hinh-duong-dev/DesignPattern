using BuilderPattern.CarParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class CarBuilder : ICarBuilder
    {
        public Engine Engine { get; set; }

        public SeatBelt SeatBelt { get; set; }

        public Windscreen Windscreen { get; set; }

        public string Color { get; set; }

        public int NumberOfWheels { get; set; }


        public CarBuilder AddEngine(Engine engine)
        {
            Engine = engine;
            return this;
        }

        public CarBuilder AddSeatBelts(SeatBelt seatBelt)
        {
            SeatBelt = seatBelt;
            return this;
        }

        public CarBuilder AddWheels(int numberOfWeels)
        {
            NumberOfWheels = numberOfWeels;
            return this;
        }

        public CarBuilder AddWindscreen(Windscreen windscreen)
        {
            Windscreen = windscreen;
            return this;
        }

        public CarBuilder Paint(string color)
        {
            Color = color;
            return this;
        }

        public Car Build()
        {
            return new Car(NumberOfWheels, SeatBelt, Windscreen, Engine, Color);
        }
    }
}
