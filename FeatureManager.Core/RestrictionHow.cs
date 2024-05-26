using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class RestrictionHow : BaseRestriction
    {
        public RestrictionHow()
        {
        }

        public RestrictionHow(string name) : base(name)
        {
        }

        public RestrictionHow(string name, string description) : base(name, description)
        {
        }
    }
}
