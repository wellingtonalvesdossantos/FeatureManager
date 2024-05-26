using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Providers
{
    public interface IProvider<T>
    {
        T Provide();
    }
}
