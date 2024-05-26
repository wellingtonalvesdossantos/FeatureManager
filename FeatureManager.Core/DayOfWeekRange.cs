namespace FeatureManager.Core
{
    public class DayOfWeekRange : Range<DayOfWeek>
    {
        public DayOfWeekRange()
        {
        }

        public DayOfWeekRange(DayOfWeek ini, DayOfWeek end) : base(ini, end)
        {
        }
    }
}
