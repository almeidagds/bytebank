using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    public class Employee
    {   
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }

        public Employee(string cpf, double salary)
        {
            Cpf = cpf;
            Salary = salary;
            NumberOfEmployees++;
        }

        public virtual double getBonus()
        {
            return Salary * 0.1;
        }

        public static int NumberOfEmployees { get; private set; }

        public virtual void RiseSalary()
        {
            this.Salary *= 1.1;
        }
    }
}
