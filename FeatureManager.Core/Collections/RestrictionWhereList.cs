using FeatureManager.Core.Protections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Collections
{
    public class RestrictionWhereList : ApplicationList<RestrictionWhere>
    {
        public RestrictionWhereList()
        {
        }

        public RestrictionWhereList(int capacity) : base(capacity)
        {
        }

        public RestrictionWhereList(IEnumerable<RestrictionWhere> collection) : base(collection)
        {
        }

        public RestrictionWhereList(params RestrictionWhere[] collection) : base(collection)
        {
        }
    }
}
