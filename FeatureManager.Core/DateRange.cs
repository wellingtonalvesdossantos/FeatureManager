using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class DateRange : Range<DateOnly>
    {
        public DateRange()
        {
        }

        public DateRange(DateOnly ini, DateOnly end) : base(ini, end)
        {
        }
    }
}
