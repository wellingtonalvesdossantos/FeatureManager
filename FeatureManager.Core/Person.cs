using FeatureManager.Core.Types;

namespace FeatureManager.Core
{
    public class Person : BasePerson
    {
        public CPF? CPF { get; }
        public Profession? Profession { get; set; }

        public Person() { }

        public Person(CPF cpf, string name, DateOnly birthDate) : base(name, birthDate)
        {
            CPF = cpf;
        }
    }
}
