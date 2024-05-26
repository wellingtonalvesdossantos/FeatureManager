using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Protections
{
    public class ApplicationDateTime : IApplicationDateTime
    {
        public DateTime Now => DateTime.Now;
        public DateTime UtcNow => DateTime.UtcNow;
        public DateTime Today => DateTime.Today;
        public DateOnly TodayDate => DateOnly.FromDateTime(Today);

        public static DateTime GetNow() => DateTime.Now;
        public static DateTime GetUtcNow() => DateTime.UtcNow;
        public static DateTime GetToday() => DateTime.Today;
        public static DateOnly GetTodayDate() => DateOnly.FromDateTime(DateTime.Today);
    }
}
