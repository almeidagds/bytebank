using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    public class Designer: Employee
    {
        public Designer(string name,string cpf):base(name,cpf, 3000, 0.17, 0.11)
        {
            Console.WriteLine("Adding a new designer...");
        }
    }
}
