namespace Ovn_5_Garage.Garage
{
    internal abstract class Vehicle
    {
        public string Reg { get; set; }
        public byte Wheel { get; set; }
        public short Seat { get; set; }
        public string Vcolor { get; set; }

        public Vehicle(string reg, byte wheel, short seat, string vcolor)
        {
            Reg = reg;
            Wheel = wheel;
            Seat = seat;
            Vcolor = vcolor;
        }

        public virtual string VehicleInfo()
        {
            return $" ■ Type: {GetType().Name}" +
                $"\n ■ License Plate: {Reg}" +
                $"\n ■ Nr of wheels: {Wheel}" +
                $"\n ■ Nr of seats: {Seat}" +
                $"\n ■ Color: {Vcolor},";
        }
    }
}
