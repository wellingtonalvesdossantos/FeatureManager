
namespace FeatureManager.Core.Protections
{
    public interface IApplicationDateTime
    {
        DateTime Now { get; }
        DateTime Today { get; }
        DateTime UtcNow { get; }
        DateOnly TodayDate {  get; }
    }
}