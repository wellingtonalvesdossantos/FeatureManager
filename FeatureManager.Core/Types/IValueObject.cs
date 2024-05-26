using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Types
{
    public interface IValueObject<T>
    {
        T? Value { get; }

        void SetValue(T? value);
    }
}
