namespace Ovn_5_Garage.Garage.Vehicles
{
    internal class Car : Vehicle
    {
        public string Brand { get; set; }
        public short Length { get; set; }
        public int Weight { get; set; }
        public byte Engine { get; set; }
        public int Cylvol { get; set; }
        public string Fuel { get; set; }

        public Car(string reg, byte wheel, short seat, string vcolor, string brand, short length, int weight,
        byte engine, int cylvol, string fuel) : base(reg, wheel, seat, vcolor)
        {
            Brand = brand;
            Length = length;
            Weight = weight;
            Engine = engine;
            Cylvol = cylvol;
            Fuel = fuel;
        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}" +
                $"\n ■ Brand: {Brand}" +
                $"\n ■ Length: {Length}" +
                $"\n ■ Weight: {Weight}" +
                $"\n ■ Nr of engines: {Engine}" +
                $"\n ■ Total cyl vol: {Cylvol}" +
                $"\n ■ Fuel: {Fuel}";
        }

        public static bool[] Seq6() // Brand, Length, Weight, Engine, Cylvol, Fuel
        {
            return new bool[] { true, true, true, true, true, true }; // Sekvensangivelse, vilka inmatningar som ska göras.
        }
    }
}
