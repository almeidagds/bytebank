using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Employees;
using bytebank.CommercialPartnership;

namespace bytebank.InternalSystem
{
    public class InternalSystem
    {
        public bool Login(Authenticable employee, string password)
        {
            bool IsAuthenticatedUser = employee.Authenticate(password);

            if (IsAuthenticatedUser)
            {
                Console.WriteLine("Welcome to the system!");
            }
            else
            {
                Console.WriteLine("Incorrect password!");
            }

            return IsAuthenticatedUser;
        }

        public bool Login(CommercialPartner employee, string password)
        {
            bool IsAuthenticatedUser = employee.Authenticate(password);

            if (IsAuthenticatedUser)
            {
                Console.WriteLine("Welcome to the system!");
            }
            else
            {
                Console.WriteLine("Incorrect password!");
            }

            return IsAuthenticatedUser;
        }
    }
}
