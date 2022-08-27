using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Employees;

namespace bytebank.InternalSystem
{
    public abstract class Authenticable: Employee
    {
        public string Password { get; set; }

        public Authenticable(
            string name, 
            string cpf, 
            double salary, 
            double bonusPercentage, 
            double salaryIncreasePercentage, 
            string password)
            :base(name, cpf, salary, bonusPercentage, salaryIncreasePercentage)
        {
            Password = password;
        }
        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
