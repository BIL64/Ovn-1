namespace Ovn_5_Garage.UserInterface
{
    internal class InputGarage
    {
        string str = "";
        int number;
        readonly byte Yp1 = 19; // Y-positionen för inputs.
        readonly byte Yp2 = 21; // Y-positionen för fel och varningar.

        public string Input1()
        {
            do
            {
                CC.ClearIn(0, Yp1, 65, 1, 0, true);
                CC.W("Please set a NAME for the new garage: ");
                str = CC.RL();
            } while (ValidateType());
            return (str);
        }

        public (string, int) Input2()
        {
            CC.ClearIn(0, Yp1, 65, 3, 0, true);
            do
            {
                CC.ClearIn(0, Yp1, 65, 1, 0, true);
                CC.W("Please set the NUMBER of parking spaces (min 3): ");
                str = CC.RL();
            } while (ValidateInt());
            return (str, number);
        }

        private bool ValidateType()
        {
            if (str != "")
            {
                if (str.Length < 3)
                {
                    CC.ClearIn(0, Yp2, 65, 1, 0, true);
                    CC.WY("A name less than three letters cannot be accepted! Try again...\a");
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
                    number = int.Parse(str);
                    return false;
                }
                catch
                {
                    CC.ClearIn(0, Yp2, 65, 1, 0, true);
                    CC.WY("Not a valid positive integer! Try again...\a");
                    return true;
                }
            }
            return false;
        }
    }
}
