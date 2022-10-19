using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter vehicle type");
            string inputVehicle = Console.ReadLine();

            Vehicle vehicle = VehicleFactory.CreateVehicle(inputVehicle);

            Console.WriteLine($"Type is {vehicle.VehicleType()}");
            Console.WriteLine($"Number of wheels is {vehicle.NumberOfWheels()}");

            Console.ReadKey();
        }
    }
}
