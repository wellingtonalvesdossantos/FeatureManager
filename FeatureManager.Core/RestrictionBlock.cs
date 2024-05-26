using FeatureManager.Core.Collections;

namespace FeatureManager.Core
{
    public class RestrictionBlock : BaseRestriction
    {
        public RestrictionBlock()
        {
        }

        public RestrictionBlock(string name) : base(name)
        {
        }

        public RestrictionBlock(string name, string description) : base(name, description)
        {
        }

        public RestrictionHowList How { get; set; } = [];
        public RestrictionWhereList Where { get; set; } = [];
        public RestrictionWhenList When { get; set; } = [];
        public RestrictionWhoList Who { get; set; } = [];
    }
}
