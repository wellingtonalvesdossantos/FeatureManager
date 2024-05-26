using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Protections
{
    public class ApplicationDirectory : IApplicationDirectory
    {
        public string Current => Directory.GetCurrentDirectory();
        public string TempFileName => Path.GetTempFileName();
        public string TempPath => Path.GetTempPath();

        public static string GetCurrent() => Directory.GetCurrentDirectory();
        public static string GetTempFileName() => Path.GetTempFileName();
        public static string GetTempPath() => Path.GetTempPath();
    }
}
