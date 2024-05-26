using FeatureManager.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public class DateTimeTarget : IDateTimeTarget
    {
        public Period Range { get; } = new();

        public DateTimeTarget() { }

        public DateTimeTarget(DateTime dateTime)
        {
            Range = new(dateTime, dateTime);
        }

        public DateTimeTarget(DateTime ini, DateTime end)
        {
            Range = new(ini, end);
        }

        public bool IsMatch(DateTime dateTime)
        {
            return Range.IsBetween(dateTime);
        }
    }
}
