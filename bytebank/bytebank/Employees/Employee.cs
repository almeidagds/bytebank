using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    public class Employee
    {   
        public Employee(int type)
        {
            this._type = type;
        }

        private int _type;
        public string Name { get; set; }
        public string Cpf { get; set; }
        public double Salary { get; set; }

        public double getBonus()
        {
            if (_type === 1)
            {
                return Salary;
            }
            return Salary * 0.1;
        }
    }
}
