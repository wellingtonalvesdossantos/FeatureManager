using FeatureManager.Core.Interfaces;

namespace FeatureManager.Core
{
    public class Feature : IId, IName, IDescription
    {
        public Feature() { }

        public Feature(string name)
        {
            Name = name;
        }

        public Feature(string name, string description) : this(name)
        {
            Description = description;
        }

        public override string ToString() => Name ?? Id;

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
