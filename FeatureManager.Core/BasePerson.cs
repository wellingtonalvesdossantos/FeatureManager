using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public abstract class BasePerson
    {
        protected BasePerson() { }

        protected BasePerson(string name, DateOnly birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public string? Name { get; set; }
        public DateOnly? BirthDate { get; set; }

        public override string? ToString() => Name;
    }
}
