﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    internal class CEO:Employee
    {
        public CEO(string name, string cpf):base(name, cpf, 5000, 0.5, 0.15)
        {
            Console.WriteLine("Adding a new CEO...");
        }
    }
}
