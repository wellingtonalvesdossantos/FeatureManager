using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Interfaces
{
    public interface IDateTimeTarget
    {
        bool IsMatch(DateTime dateTime);
    }
}
