using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    public class Assistant: Employee
    {
        public Assistant(string name, string cpf):base(name, cpf, 2000, 0.2, 0.1)
        {
            Console.WriteLine("Adding a new assistant...");
        } 
    }
}
