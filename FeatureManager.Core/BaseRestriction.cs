using FeatureManager.Core.Interfaces;

namespace FeatureManager.Core
{
    public abstract class BaseRestriction : IId, IName, IDescription
    {
        public string Id => Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public string? Description { get; set; }

        public BaseRestriction() { }

        public BaseRestriction(string name) 
        {
            Name = name;
        }

        public BaseRestriction(string name, string description) : this(name)
        {
            Description = description;
        }

        public override string? ToString() => Name ?? Id;
    }
}