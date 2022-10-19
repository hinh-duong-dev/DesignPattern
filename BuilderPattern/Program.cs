using BuilderPattern.CarParts;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car(4,
                      new SeatBelt("Luxe"),
                      new Windscreen("Fia"),
                      new Engine("Suzuki"),
                      "Red");

            var carByBuilder = new CarBuilder()
                                      .AddWheels(4)
                                      .AddSeatBelts(new SeatBelt("Aptiv"))
                                      .AddWindscreen(new Windscreen("Windshield"))
                                      .AddEngine(new Engine("Toyata"))
                                      .Paint("Blue")
                                      .Build();

            Console.WriteLine(car.ToString());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(carByBuilder.ToString());

            Console.ReadKey();
        }
    }
}
