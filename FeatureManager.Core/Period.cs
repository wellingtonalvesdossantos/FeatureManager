using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class Period : Range<DateTime>
    {
        public Period()
        {
        }

        public Period(DateTime ini, DateTime end) : base(ini, end)
        {
        }
    }
}
