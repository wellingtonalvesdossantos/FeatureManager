﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Builders
{
    public interface IBuilder<T>
    {
        T Build();
    }
}
