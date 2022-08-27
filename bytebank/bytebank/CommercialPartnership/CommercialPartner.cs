using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.CommercialPartnership
{
    public class CommercialPartner
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
