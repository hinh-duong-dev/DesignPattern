using BuilderPattern.CarParts;

namespace BuilderPattern
{
    interface ICarBuilder
    {
        CarBuilder AddEngine(Engine engine);

        CarBuilder AddSeatBelts(SeatBelt seatBelt);

        CarBuilder AddWindscreen(Windscreen windscreen);

        CarBuilder AddWheels(int numberOfWeels);

        CarBuilder Paint(string color);

        public Car Build();

    }
}