using FeatureManager.Core.Interfaces;
using FeatureManager.Core.Protections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Appliers
{
    public class WhoApplier
    {
        private readonly IGlobalContext<User> _loggedUserContext;

        public WhoApplier(IGlobalContext<User> loggedUserContext)
        {
            _loggedUserContext = loggedUserContext;
        }

        public bool IsMatch(RestrictionWho item)
        {
            return item.IsMatch(_loggedUserContext.Value!);
        }

        public bool IsMatch(IEnumerable<RestrictionWho> list)
        {
            foreach (var item in list)
            {
                if (IsMatch(item)) return true;
            }
            return false;
        }
    }
}
