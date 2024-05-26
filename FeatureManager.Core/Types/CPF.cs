using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FeatureManager.Core.Types
{
    public class CPF : ValueObject<string>
    {
        private const string MASKED_REGEX = "^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$";
        private const string UNMASKED_REGEX = "^[0-9]{11}$";
        private const string REGEX_REPLACE_PATTERN = "[^0-9]";

        protected override (bool, string?) IsValid(string? value)
        {
            if (value == null) return (true, value);
            if (Regex.IsMatch(value, MASKED_REGEX)) return (true, Regex.Replace(value, REGEX_REPLACE_PATTERN, ""));
            if (!Regex.IsMatch(value, UNMASKED_REGEX)) return (false, value);
            return (true, value);
        }

        public CPF() { }

        public CPF(string? value) : base(value) { }
    }
}
