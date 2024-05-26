using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static int GetAge(this DateTime dateTime, DateTime? baseForCalculation = null)
        {
            var baseForCalc = baseForCalculation ?? DateTime.Now;
            if (dateTime.Year > baseForCalc.Year) return 0;
            var birthday = baseForCalc.Month > dateTime.Month || 
                (dateTime.Month == baseForCalc.Month || baseForCalc.Day >= dateTime.Day);
            return baseForCalc.Year - dateTime.Year - (birthday ? 0 : 1);
        }

        public static bool IsBirthday(this DateTime dateTime, DateTime? baseForCalculation = null)
        {
            var baseForCalc = baseForCalculation ?? DateTime.Now;
            return dateTime.Month == baseForCalc.Month && baseForCalc.Day == dateTime.Day;
        }
    }
}
