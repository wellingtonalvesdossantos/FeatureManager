using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.ViewModels
{
    public abstract class BasePersonViewModel
    {
        public string? Name { get; set; }
        public DateOnly? BirthDate { get; set; }

        public override string? ToString() => Name;
    }
}
