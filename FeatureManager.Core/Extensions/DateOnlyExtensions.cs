using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Extensions
{
    public static class DateOnlyExtensions
    {
        public static int GetAge(this DateOnly DateOnly, DateOnly? baseForCalculation = null)
        {
            var baseForCalc = baseForCalculation ?? DateOnly.FromDateTime(DateTime.Now);
            if (DateOnly.Year > baseForCalc.Year) return 0;
            var birthday = baseForCalc.Month > DateOnly.Month || 
                (DateOnly.Month == baseForCalc.Month || baseForCalc.Day >= DateOnly.Day);
            return baseForCalc.Year - DateOnly.Year - (birthday ? 0 : 1);
        }

        public static bool IsBirthday(this DateOnly DateOnly, DateOnly? baseForCalculation = null)
        {
            var baseForCalc = baseForCalculation ?? DateOnly.FromDateTime(DateTime.Now);
            return DateOnly.Month == baseForCalc.Month && baseForCalc.Day == DateOnly.Day;
        }
    }
}
