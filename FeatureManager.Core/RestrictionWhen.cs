using FeatureManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class RestrictionWhen : BaseRestriction
    {
        public IDateTimeTarget DateTimeTarget { get; }

        public RestrictionWhen(IDateTimeTarget dateTimeTarget)
        {
            DateTimeTarget = dateTimeTarget;
        }

        public RestrictionWhen(IDateTimeTarget dateTimeTarget, string name) : base(name)
        {
            DateTimeTarget = dateTimeTarget;
        }

        public RestrictionWhen(IDateTimeTarget dateTimeTarget, string name, string description) : base(name, description)
        {
            DateTimeTarget = dateTimeTarget;
        }

        public bool IsMatch(DateTime baseForCalculation)
        {
            return DateTimeTarget.IsMatch(baseForCalculation);
        }
    }
}
