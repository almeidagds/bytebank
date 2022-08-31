using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Clients
{
    public class Client
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Job { get; set; }

        public Client(string name, string cpf, string job)
        {
            Name = name;
            Cpf = cpf;
            Job = job;
        }
    }
}
