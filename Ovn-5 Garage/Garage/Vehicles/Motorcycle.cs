namespace Ovn_5_Garage.Garage.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public string Brand { get; set; }
        public int Cylvol { get; set; }
        public string Fuel { get; set; }

        public Motorcycle(string reg, byte wheel, short seat, string vcolor, string brand,
        int cylvol, string fuel) : base(reg, wheel, seat, vcolor)
        {
            Brand = brand;
            Cylvol = cylvol;
            Fuel = fuel;
        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}" +
                $"\n ■ Brand: {Brand}" +
                $"\n ■ Total cyl vol: {Cylvol}" +
                $"\n ■ Fuel: {Fuel}";
        }

        public static bool[] Seq6() // Brand, Length, Weight, Engine, Cylvol, Fuel
        {
            return new bool[] { true, false, false, false, true, true };
        }
    }
}
