using FeatureManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class DateTarget : IDateTimeTarget
    {
        public DateRange Range { get; } = new();

        public DateTarget() { }

        public DateTarget(DateOnly date)
        {
            Range = new(date, date);
        }

        public DateTarget(DateOnly ini, DateOnly end)
        {
            Range = new(ini, end);
        }

        public bool IsMatch(DateTime dateTime)
        {
            return Range.IsBetween(DateOnly.FromDateTime(dateTime));
        }
    }
}
