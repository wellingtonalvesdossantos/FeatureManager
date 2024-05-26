using FeatureManager.Core.Protections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Collections
{
    public class RestrictionWhoList : ApplicationList<RestrictionWho>
    {
        public RestrictionWhoList()
        {
        }

        public RestrictionWhoList(int capacity) : base(capacity)
        {
        }

        public RestrictionWhoList(IEnumerable<RestrictionWho> collection) : base(collection)
        {
        }

        public RestrictionWhoList(params RestrictionWho[] collection) : base(collection)
        {
        }
    }
}
