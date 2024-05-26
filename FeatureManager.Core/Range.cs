using FeatureManager.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core
{
    public abstract class Range<T> where T : IComparable
    {
        public T? Ini { get; protected set; }
        public T? End { get; protected set; }

        protected virtual bool GenerateExceptionForInvalidValues => true;

        public Range() { }

        public Range(T? ini, T? end) => SetValues(ini, end);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ini"></param>
        /// <param name="end"></param>
        /// <exception cref="InvalidDataException"></exception>
        public void SetValues(T? ini, T? end)
        {
            var validationResult = IsValid(ini, end);
            if (!validationResult.Item1)
            {
                if (GenerateExceptionForInvalidValues) throw new InvalidDataException();
                return;
            }
            Ini = validationResult.Item2;
            End = validationResult.Item3;
        }

        protected virtual (bool, T?, T?) IsValid(T? ini, T? end)
        {
            if (ini == null || end == null) return (true, ini, end);
            if (end!.CompareTo(ini) < 0) return (false, ini, end);
            return (true, ini, end);
        }

        public bool IsBetween(T? value) => value.IsBetween(Ini, End);

        public override string ToString() => $"{Ini} - {End}";
    }
}
