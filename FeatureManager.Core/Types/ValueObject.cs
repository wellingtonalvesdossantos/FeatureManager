using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureManager.Core.Types
{
    public abstract class ValueObject<T> : IValueObject<T>
    {
        protected virtual bool GenerateExceptionForInvalidValues => true;
        public T? Value { get; private set; }

        public ValueObject() { }

        public ValueObject(T? value) => SetValue(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="InvalidDataException"></exception>
        public void SetValue(T? value)
        {
            var validationResult = IsValid(value);
            if (!validationResult.Item1)
            {
                if (GenerateExceptionForInvalidValues) throw new InvalidDataException();
                return;
            }
            Value = validationResult.Item2;
        }

        protected virtual (bool, T?) IsValid(T? value) => (true, value);

        public override string? ToString() => Value?.ToString();
    }
}
