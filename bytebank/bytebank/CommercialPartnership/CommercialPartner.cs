using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.InternalSystem;

namespace bytebank.CommercialPartnership
{
    public class CommercialPartner: IAuthenticable
    {
        public CommercialPartner (string password)
        {
            Password = password;
        }
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return this.Password == password;
        }
    }
}
