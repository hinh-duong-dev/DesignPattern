using System;

namespace AdapterPattern
{
    class PolarGraph
    {
        public void Point(double r, double t)
        {
            Console.WriteLine("Polar Coordinate Point: P(" + r + ", " + t + ")");
        }
    }
}
