﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    internal class CEO
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }

        public double getBonus()
        {
            return Salary;        
        }
    }
}
