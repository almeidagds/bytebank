using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    internal class AccountManager: Employee
    {
        public AccountManager(string name, string cpf):base(name, cpf, 4000, 0.25, 0.05)
        {
            Console.WriteLine("Adding a new account manager...");
        }
    }
}
