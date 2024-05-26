using FeatureManager.Core.Protections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Collections
{
    public class RestrictionHowList : ApplicationList<RestrictionHow>
    {
        public RestrictionHowList()
        {
        }

        public RestrictionHowList(int capacity) : base(capacity)
        {
        }

        public RestrictionHowList(IEnumerable<RestrictionHow> collection) : base(collection)
        {
        }

        public RestrictionHowList(params RestrictionHow[] collection) : base(collection)
        {
        }
    }
}
