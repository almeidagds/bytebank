using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.InternalSystem
{
    internal class AuthenticationHelper
    {
        public bool ComparePasswords(string truePassword, string tryingPassword)
        {
            return truePassword.Equals(tryingPassword);
        }
    }
}
