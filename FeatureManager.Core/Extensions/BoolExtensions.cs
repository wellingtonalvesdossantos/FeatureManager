using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Extensions
{
    public static class BoolExtensions
    {
        public static string? AsReadable(this bool? value, string trueDescription, string falseDescription, string? undefinedDescription = null)
        {
            if (value == null) return undefinedDescription;
            return value.Value ? trueDescription : falseDescription;
        }
    }
}
