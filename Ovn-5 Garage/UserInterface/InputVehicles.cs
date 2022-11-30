using Ovn_5_Garage.Garage.Vehicles;

namespace Ovn_5_Garage.UserInterface
{
    internal class InputVehicles
    {
        string str = "";
        bool[] seq = new bool[5];
        int number;
        byte bytnum;
        short shonum;
        readonly byte Yp1 = 19; // Y-positionen för inputs.
        readonly byte Yp2 = 22; // Y-positionen för fel och varningar.

        public (string, bool[]) Input1()
        {
            do
            {
                CC.ClearIn(0, Yp1, 110, 2, 0, true);
                CC.WL("Please enter TYPE of vehicle");
                CC.W("car = Car, mot = Motorcycle, bus = Bus, boa = Boat, air = Airplane: ");
                str = CC.RL();
            } while (ValidateType());
            return (str, seq);
        }

        public string Input2()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 2, 0, true);
                CC.W("Please enter the vehicle REG NUMBER: ");
                str = CC.RL();
            } while (ValidateReg());
            return str;
        }

        public (string, byte) Input3()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 2, 0, true);
                CC.WL("Please enter the number of WHEELS on the vehicle");
                CC.W("For boats and airplane type \"0\" = zero: ");
                str = CC.RL();
            } while (ValidateByt());
            return (str, bytnum);
        }

        public (string, short) Input4()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 2, 0, true);
                CC.WL("Please enter the number of SEATS on the vehicle");
                CC.W("\"0\" = zero is accepted: ");
                str = CC.RL();
            } while (ValidateSho());
            return (str, shonum);
        }

        public string Input5()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 1, 0, true);
                CC.W("Please enter the vehicle primery COLOR: ");
                str = CC.RL();
            } while (ValidateColor());
            return (str);
        }

        public string Input6()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            CC.ClearIn(0, Yp1, 110, 1, 0, true);
            CC.W("Please enter the BRAND: ");
            str = CC.RL();
            return (str);
        }

        public (string, short) Input7()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 1, 0, true);
                CC.W("Please enter the vehicle LENGTH [meter, round it up (no decimals)]: ");
                str = CC.RL();
            } while (ValidateSho());
            return (str, shonum);
        }

        public (string, int) Input8()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 1, 0, true);
                CC.W("Please enter the vehicle WEIGHT [kg, round it up (no decimals)]: ");
                str = CC.RL();
            } while (ValidateInt());
            return (str, number);
        }

        public (string, byte) Input9()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 1, 0, true);
                CC.W("Please enter the number of ENGINES: ");
                str = CC.RL();
            } while (ValidateByt());
            return (str, bytnum);
        }

        public (string, int) Input10()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 2, 0, true);
                CC.WL("Please enter the engine CYLINDER VOLUME [cubic]");
                CC.W("For jet airoplane type \"0\" = zero: ");
                str = CC.RL();
            } while (ValidateInt());
            return (str, number);
        }

        public string Input11()
        {
            CC.ClearIn(0, Yp1, 110, 4, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 110, 2, 0, true);
                CC.WL("Please enter the engine FUEL TYPE [cubic]");
                CC.W("pet = Gasoline/Petrol, die = Diesel/Kerosene, bio = Biofuel, gas = Gas/H2, hyb = Battery/Hybride: ");
                str = CC.RL();
            } while (ValidateFuel());
            return (str);
        }

        private bool ValidateType()
        {
            if (str != "quit")
            {
                if (str != "car" && str != "mot" && str != "bus" && str != "boa" && str != "air")
                {
                    CC.ClearIn(0, Yp2, 110, 1, 0, true);
                    CC.WY("No valid character combination could be found! Try again...\a");
                    return true;
                }
                else
                {
                    if (str == "car") { str = "Car"; seq = Car.Seq6(); }
                    if (str == "mot") { str = "Motorcycle"; seq = Motorcycle.Seq6(); }
                    if (str == "bus") { str = "Bus"; seq = Bus.Seq6(); }
                    if (str == "boa") { str = "Boat"; seq = Boat.Seq6(); }
                    if (str == "air") { str = "Airplane"; seq = Airplane.Seq6(); }
                    return false;
                }
            }
            return false;
        }

        private bool ValidateFuel()
        {
            if (str != "quit")
            {
                if (str != "pet" && str != "die" && str != "bio" && str != "gas" && str != "hyb")
                {
                    CC.ClearIn(0, Yp2, 110, 1, 0, true);
                    CC.WY("No valid character combination could be found! Try again...\a");
                    return true;
                }
                else
                {
                    if (str == "pet") str = "Gasoline/Petrol";
                    if (str == "die") str = "Diesel/Kerosene";
                    if (str == "bio") str = "Biofuel";
                    if (str == "gas") str = "Gas/H2";
                    if (str == "hyb") str = "Battery/Hybride";
                    return false;
                }
            }
            return false;
        }

        private bool ValidateColor()
        {
            bool FindC = false;

            string[] Color = { "white", "gray", "yellow", "green", "orange", "red", "blue", "pink", "black" };

            if (str != "quit")
            {
                foreach (var item in Color)
                {
                    if (str.ToLower() == item) { str = item[..1].ToUpper() + item[1..].ToLower(); FindC = true; }
                }
                if (!FindC)
                {
                    CC.ClearIn(0, Yp2, 110, 1, 0, true);
                    CC.WY("No valid primery color could be found! Try again...\a");
                    return true;
                }
                else return false;
            }
            return false;
        }

        private bool ValidateReg()
        {
            if (str != "quit")
            {
                if (str.Length < 3)
                {
                    CC.ClearIn(0, Yp2, 110, 1, 0, true);
                    CC.WY("A reg number less than three letters cannot be accepted! Try again...\a");
                    return true;
                }
                else return false;
            }
            return false;
        }

        private bool ValidateByt()
        {
            if (str != "quit")
            {
                try
                {
                    bytnum = byte.Parse(str);
                    return false;
                }
                catch
                {
                    CC.ClearIn(0, Yp2, 110, 1, 0, true);
                    CC.WY("Not a valid positive integer! Try again...\a");
                    return true;
                }
            }
            return false;
        }

        private bool ValidateSho()
        {
            if (str != "quit")
            {
                try
                {
                    shonum = short.Parse(str);
                    return false;
                }
                catch
                {
                    CC.ClearIn(0, Yp2, 110, 1, 0, true);
                    CC.WY("Not a valid positive integer! Try again...\a");
                    return true;
                }
            }
            return false;
        }

        private bool ValidateInt()
        {
            if (str != "quit")
            {
                try
                {
                    number = int.Parse(str);
                    return false;
                }
                catch
                {
                    CC.ClearIn(0, Yp2, 110, 1, 0, true);
                    CC.WY("Not a valid positive integer! Try again...\a");
                    return true;
                }
            }
            return false;
        }
    }
}
