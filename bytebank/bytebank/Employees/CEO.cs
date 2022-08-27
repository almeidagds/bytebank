using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    internal class CEO:Employee
    {
        public CEO(string cpf, double salary):base(cpf, salary)
        {

        }
        public override double getBonus()
        {
            return Salary + base.getBonus();        
        }

        public override void RiseSalary()
        {
            this.Salary *= 1.15;
        }
    }
}
