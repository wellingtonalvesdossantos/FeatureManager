using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Extensions
{
    public static class CompareExtensions
    {
        public static bool IsBetween<T>(this T value, T ini, T end) where T : IComparable
        {
            return value.CompareTo(ini) >= 0 && value.CompareTo(end) <= 0;
        }
    }
}
