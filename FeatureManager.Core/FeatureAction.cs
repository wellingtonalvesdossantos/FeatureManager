using FeatureManager.Core.Collections;
using FeatureManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class FeatureAction : IId, IName, IDescription
    {
        public FeatureAction() { }

        public FeatureAction(string name)
        {
            Name = name;
        }

        public FeatureAction(string name, string description) : this(name)
        {
            Description = description;
        }

        public override string ToString() => Name ?? Id;

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string? Name { get; set; }
        public string? Description { get; set; }
        public GeoLocation? Geolocation { get; set; }
        public RestrictionBlockList RestrictionBlocks { get; set; } = [];
    }
}
