using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public abstract class Vehicle
    {
        protected int Wheels;

        public abstract string VehicleType();

        public abstract int NumberOfWheels();
    }
}
