namespace FactoryPattern
{
    public class Car : Vehicle
    {
        public Car()
        {
            Wheels = 4;
        }

        public override int NumberOfWheels()
        {
            return Wheels;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
