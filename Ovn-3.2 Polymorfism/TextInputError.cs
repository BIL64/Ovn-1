using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn_3._2_Polymorfism
{
    internal class TextInputError : UserError
    {
        public override string UEMessage(string err)
        {
            err = "You tried to use a text input in a text only field. This fired an error!";
            return err;
        }
    }
}
