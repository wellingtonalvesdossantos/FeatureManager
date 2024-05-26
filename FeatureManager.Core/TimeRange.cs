using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class TimeRange : Range<TimeOnly>
    {
        public TimeRange()
        {
        }

        public TimeRange(TimeOnly ini, TimeOnly end) : base(ini, end)
        {
        }
    }
}
