using FeatureManager.Core.Interfaces;
using FeatureManager.Core.Types;

namespace FeatureManager.Core
{
    public abstract class GlobalContext<T> : ValueObject<T>, IGlobalContext<T>
    {
    }
}
