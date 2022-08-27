using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Employees
{
    public abstract class Employee
    {   
        public string Name { get; set; }
        public string Cpf { get; private set; }
        public double Salary { get; protected set; }
        public double BonusPercentage { get; protected set; }
        public double SalaryIncreasePercentage { get; protected set; }

        public Employee(
            string name,
            string cpf,
            double salary,
            double bonusPercentage,
            double salaryIncreasePercentage
            )
        {
            Name = name;
            Cpf = cpf;
            Salary = salary;
            BonusPercentage = bonusPercentage;
            SalaryIncreasePercentage = salaryIncreasePercentage;

            NumberOfEmployees++;
        }

        public double GetBonus()
        {
            return Salary * BonusPercentage;
        }

        public void RiseSalary()
        {
            this.Salary *= (1 + SalaryIncreasePercentage);
        }

        public static int NumberOfEmployees { get; private set; }
    }
}
