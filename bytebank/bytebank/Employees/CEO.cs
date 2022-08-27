using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    public class CEO:AuthenticableEmployee
    {
        public CEO(string name, string cpf, string password) : base(name, cpf, 5000, 0.5, 0.15, password)
        {
            Console.WriteLine("Adding a new CEO...");
        }
    }
}
