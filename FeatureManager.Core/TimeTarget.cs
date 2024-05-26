using FeatureManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class TimeTarget : IDateTimeTarget
    {
        public TimeRange Range { get; } = new();

        public TimeTarget() { }

        public TimeTarget(TimeOnly time)
        {
            Range = new(time, time);
        }

        public TimeTarget(TimeOnly ini, TimeOnly end)
        {
            Range = new(ini, end);
        }

        public bool IsMatch(DateTime dateTime)
        {
            return Range.IsBetween(TimeOnly.FromDateTime(dateTime));
        }
    }
}
