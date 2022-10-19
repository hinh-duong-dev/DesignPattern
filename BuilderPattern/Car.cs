using BuilderPattern.CarParts;

namespace BuilderPattern
{
    class Car
    {
        public int NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Color { get; set; }
        public Windscreen Windscreen { get; set; }
        public Engine Engine { get; set; }

        public Car(int numberOfWheels,
                   SeatBelt seatBelt,
                   Windscreen windscreen,
                   Engine engine,
                   string color)
        {
            NumberOfWheels = numberOfWheels;
            SeatBelt = seatBelt;
            Windscreen = windscreen;
            Engine = engine;
            Color = color;
        }

        public override string ToString()
        {
            var content = "";
            content += $"Number of wheels:    \t {NumberOfWheels}\n";
            content += $"Brand of seat belts: \t {SeatBelt.Brand}\n";
            content += $"Color:               \t {Color}\n";
            content += $"Windscreen brand:    \t {Windscreen.Name}\n";
            content += $"Engine:              \t {Engine.Name}";
            return content;
        }
    }
}
