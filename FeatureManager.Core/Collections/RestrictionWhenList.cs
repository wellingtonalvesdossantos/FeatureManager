using FeatureManager.Core.Protections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Collections
{
    public class RestrictionWhenList : ApplicationList<RestrictionWhen>
    {
        public RestrictionWhenList()
        {
        }

        public RestrictionWhenList(int capacity) : base(capacity)
        {
        }

        public RestrictionWhenList(IEnumerable<RestrictionWhen> collection) : base(collection)
        {
        }

        public RestrictionWhenList(params RestrictionWhen[] collection) : base(collection)
        {
        }
    }
}
