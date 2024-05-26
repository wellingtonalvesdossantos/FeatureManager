namespace FeatureManager.Core.Protections
{
    public interface IApplicationDirectory
    {
        string Current { get; }
        string TempFileName { get; }
        string TempPath { get; }
    }
}