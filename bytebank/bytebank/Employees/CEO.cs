using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    internal class CEO:Employee
    {
        public CEO(string cpf):base(cpf)
        {

        }
        public override double getBonus()
        {
            return Salary + base.getBonus();        
        }
    }
}
