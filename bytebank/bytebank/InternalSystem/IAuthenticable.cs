using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Employees;

namespace bytebank.InternalSystem
{
    public interface IAuthenticable
    {
        public bool Authenticate(string password);
    }
}
