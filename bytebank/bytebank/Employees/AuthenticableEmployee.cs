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

        private AuthenticationHelper _authenticationHelper = new AuthenticationHelper();

        protected AuthenticableEmployee(string name, string cpf, double salary, double bonusPercentage, double salaryIncreasePercentage, string password) : base(name, cpf, salary, bonusPercentage, salaryIncreasePercentage)
        {
            Password = password;
        }

        public bool Authenticate(string password)
        {
            return _authenticationHelper.ComparePasswords(Password, password);
        }
    }
}
