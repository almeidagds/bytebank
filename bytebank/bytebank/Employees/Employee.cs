﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    public class Employee
    {   
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            NumberOfEmployees++;
        }

        public virtual double getBonus()
        {
            return Salary * 0.1;
        }

        public static int NumberOfEmployees { get; private set; }
    }
}
