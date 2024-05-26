using FeatureManager.Core.Protections;

namespace FeatureManager.Core.Collections
{
    public class RestrictionBlockList : ApplicationList<RestrictionBlock>
    {
        public RestrictionBlockList()
        {
        }

        public RestrictionBlockList(int capacity) : base(capacity)
        {
        }

        public RestrictionBlockList(IEnumerable<RestrictionBlock> collection) : base(collection)
        {
        }

        public RestrictionBlockList(params RestrictionBlock[] collection) : base(collection)
        {
        }
    }
}
