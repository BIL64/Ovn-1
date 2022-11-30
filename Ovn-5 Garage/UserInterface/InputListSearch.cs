namespace Ovn_5_Garage.UserInterface
{
    internal class InputListSearch : IInputListSearch
    {
        string str = "";
        short shonum;
        readonly byte Yp1 = 19; // Y-positionen för inputs.
        readonly byte Yp2 = 22; // Y-positionen för fel och varningar.

        public string Input1()
        {
            do
            {
                CC.ClearIn(0, Yp1, 100, 2, 0, true);
                CC.WL("Try to find the vehicle by enter search strings, like abc123+red...)");
                CC.W("Separate every search string with a plus sign \"+\": ");
                str = CC.RL();
            } while (ValidateSearch());
            return str;
        }

        public (string, short) Input2()
        {
            CC.ClearIn(0, Yp1, 100, 4, 0, false);
            do
            {
                CC.ClearIn(0, Yp1, 100, 1, 0, true);
                CC.W("Now, if you find the vehicle - enter the List Number: ");
                str = CC.RL();
            } while (ValidateInt());
            return (str, shonum);
        }

        public string Input3()
        {
            do
            {
                CC.ClearIn(0, Yp1, 100, 2, 0, true);
                CC.WL("Please enter the TYPE of vehicle that will be listed");
                CC.W("car = Car, mot = Motorcycle, bus = Bus, boa = Boat, air = Airplane: ");
                str = CC.RL();
            } while (ValidateType());
            return str;
        }

        public string Input4()
        {
            do
            {
                CC.ClearIn(0, Yp1, 100, 1, 0, true);
                CC.W("Search only for REG NUMBER: ");
                str = CC.RL();
            } while (ValidateSearch());
            return str;
        }

        private bool ValidateSearch()
        {
            if (str != "")
            {
                if (str.Length < 3)
                {
                    CC.ClearIn(0, Yp2, 100, 1, 0, true);
                    CC.WY("At least three characters, please! Try again...\a");
                    return true;
                }
                else return false;
            }
            return false;
        }

        private bool ValidateInt()
        {
            if (str != "")
            {
                try
                {
                    shonum = short.Parse(str);
                    return false;
                }
                catch
                {
                    CC.ClearIn(0, Yp2, 100, 1, 0, true);
                    CC.WY("Not a valid positive integer! Try again...\a");
                    return true;
                }
            }
            return false;
        }

        private bool ValidateType()
        {
            if (str != "")
            {
                if (str != "car" && str != "mot" && str != "bus" && str != "boa" && str != "air")
                {
                    CC.ClearIn(0, Yp2, 100, 1, 0, true);
                    CC.WY("No valid character combination could be found! Try again...\a");
                    return true;
                }
                else
                {
                    if (str == "car") str = "Car";
                    if (str == "mot") str = "Motorcycle";
                    if (str == "bus") str = "Bus";
                    if (str == "boa") str = "boat";
                    if (str == "air") str = "Airoplane";
                    return false;
                }
            }
            return false;
        }
    }
}
