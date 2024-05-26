using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeatureManager.Core.Types;

namespace FeatureManager.Core
{
    public class Address
    {
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public CEP? CEP { get; set; }

        public Address() { }

        public Address(string logradouro, string numero, CEP cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            CEP = cep;
        }
    }
}
