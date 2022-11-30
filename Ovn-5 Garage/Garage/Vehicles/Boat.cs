﻿namespace Ovn_5_Garage.Garage.Vehicles
{
    internal class Boat : Vehicle
    {
        public string Brand { get; set; }
        public short Length { get; set; }
        public int Weight { get; set; }
        public byte Engine { get; set; }
        public string Fuel { get; set; }

        public Boat(string reg, byte wheel, short seat, string vcolor, string brand, short length, int weight,
        byte engine, string fuel) : base(reg, wheel, seat, vcolor)
        {
            Brand = brand;
            Length = length;
            Weight = weight;
            Engine = engine;
            Fuel = fuel;
        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}" +
                $"\n ■ Brand: {Brand}" +
                $"\n ■ Length: {Length}" +
                $"\n ■ Weight: {Weight}" +
                $"\n ■ Nr of engines: {Engine}" +
                $"\n ■ Fuel: {Fuel}";
        }

        public static bool[] Seq6() // Brand, Length, Weight, Engine, Cylvol, Fuel
        {
            return new bool[] { true, true, true, true, false, true };
        }
    }
}
