using FeatureManager.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class LegalPerson : BasePerson
    {
        public LegalPerson() { }

        public LegalPerson(CNPJ cnpj)
        {
            CNPJ = cnpj;
        }

        public LegalPerson(CNPJ cnpj, string name, DateOnly birthDate) : base(name, birthDate)
        {
            CNPJ = cnpj;
        }

        public CNPJ? CNPJ { get; set; }
    }
}
