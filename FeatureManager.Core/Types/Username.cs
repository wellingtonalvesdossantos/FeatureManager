using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Types
{
    public class Username : ValueObject<string>
    {
        public Username()
        {
        }

        public Username(string? value) : base(value)
        {
        }
    }
}
