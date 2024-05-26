using FeatureManager.Core.Collections;
using FeatureManager.Core.Protections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Appliers
{
    public class WhenApplier
    {
        private readonly IApplicationDateTime _applicationDateTime;

        public WhenApplier(IApplicationDateTime applicationDateTime)
        {
            _applicationDateTime = applicationDateTime;
        }

        public bool IsMatch(RestrictionWhen item)
        {
            return item.IsMatch(_applicationDateTime.Now);
        }

        public bool IsMatch(IEnumerable<RestrictionWhen> list)
        {
            foreach (var item in list)
            {
                if (IsMatch(item)) return true;
            }
            return false;
        }
    }
}
