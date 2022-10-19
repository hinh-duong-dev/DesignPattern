namespace FactoryPattern
{
    public class Bike : Vehicle
    {
        public Bike()
        {
            Wheels = 2;
        }

        public override int NumberOfWheels()
        {
            return Wheels;
        }

        public override string VehicleType()
        {
            return "Bike";
        }
    }
}
