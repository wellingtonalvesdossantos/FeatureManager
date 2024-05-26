namespace FeatureManager.Core.Protections
{
    public interface IApplicationTranslator
    {
        TDestination Translate<TDestination>(object source);
        TDestination Translate<TSource, TDestination>(TSource source);
    }
}