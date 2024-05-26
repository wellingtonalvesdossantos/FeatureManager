using FeatureManager.Core.Enums;

namespace FeatureManager.Core
{
    public class Profession
    {
        public Profession() { }

        public Profession(string name, EProfessionLevel level)
        {
            Name = name;
            Level = level;
        }

        public override string ToString() => 
            $"{Name.ToUpper()} {(Level == EProfessionLevel.Undefined ? "" : Level)}";

        public string? Name { get; }
        public EProfessionLevel Level { get; }
    }
}
