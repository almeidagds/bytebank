using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bytebank.Employees
{
    public class AccountManager:AuthenticableEmployee
    {
        public AccountManager(string name, string cpf, string password):base(name, cpf, 4000, 0.25, 0.05, password)
        {
            Console.WriteLine("Adding a new account manager...");
        }
    }
}
