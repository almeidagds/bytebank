using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.CustomExceptions
{
    public class MenuInvalidOptionException: Exception
    {
        public MenuInvalidOptionException(string message):base("An error ocurred: " + message)
        {
        }
    }
}
