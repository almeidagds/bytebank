using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    internal class Developer: Employee
    {
        public Developer(string name, string cpf):base(name, cpf, 3000, 0.10, 0.15)
        {
            Console.WriteLine("Adding a new developer...");
        }
    }
}
