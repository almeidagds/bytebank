using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.InternalSystem;

namespace bytebank.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        string Password { get; set; }

        protected AuthenticableEmployee(string name, string cpf, double salary, double bonusPercentage, double salaryIncreasePercentage, string password) : base(name, cpf, salary, bonusPercentage, salaryIncreasePercentage)
        {
            Password = password;
        }

        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
