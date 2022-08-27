using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Employees;

namespace bytebank.Utils
{
    internal class BonusManager
    {
        private double _bonusTotal;

        public void Registry(Employee employee)
        {
            this._bonusTotal += employee.GetBonus();
        }
        public double GetTotalBonus()
        {
            return this._bonusTotal;
        }
    }
}
