namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static Vehicle CreateVehicle(string type)
        {
            Vehicle vehicle = null;

            if (type == "Bike")
            {
                vehicle = new Bike();
            }
            else if (type == "Car")
            {
                vehicle = new Car();
            }

            return vehicle;
        }
    }
}
