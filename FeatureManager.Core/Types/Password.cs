using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Types
{
    public class Password : ValueObject<string>
    {
        public Password()
        {
        }

        public Password(string? value) : base(value)
        {
        }
    }
}
