using FeatureManager.Core.Interfaces;

namespace FeatureManager.Core
{
    public class DayOfWeekTarget : IDateTimeTarget
    {
        public DayOfWeekRange Range { get; } = new();

        public DayOfWeekTarget() { }

        public DayOfWeekTarget(DayOfWeek dayOfWeek) 
        {
            Range = new(dayOfWeek, dayOfWeek);
        }

        public DayOfWeekTarget(DayOfWeek ini, DayOfWeek end)
        {
            Range = new(ini, end);
        }

        public bool IsMatch(DateTime dateTime)
        {
            return Range.IsBetween(dateTime.DayOfWeek);
        }
    }
}
