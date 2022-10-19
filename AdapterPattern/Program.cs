using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PolarGraph polarGraph = new PolarGraph();
            IGraph graph = new PolarGraphAdapter(polarGraph);
            graph.Point(3, 4);
            //Output: Polar Coordinate Point: P(5, 0.9272952180016122)

            Console.ReadKey();
        }
    }
}
