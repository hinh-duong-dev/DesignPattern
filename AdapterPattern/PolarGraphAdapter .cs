using System;

namespace AdapterPattern
{
    class PolarGraphAdapter : IGraph
    {
        private readonly PolarGraph polarGraph;
        public PolarGraphAdapter(PolarGraph polarGraph)
        {
            //Get a reference to the object that needs to be adapted.
            this.polarGraph = polarGraph;
        }

        //Implement method Point of interface.
        public void Point(double x, double y)
        {
            //Get x and y coordinates and coordinates, process to length and rotation r, t
            double r = Math.Sqrt(x * x + y * y);
            double t = Math.Atan2(y, x);
            //Call the Point method from the polarGraph object.
            polarGraph.Point(r, t);
        }
    }
}
