using PackIT.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.ValueObjects
{
    public record Temperature
    {
        public double Value { get; }

        public Temperature(double value)
        {
            if (value is < -100 or > 100)
            {
                throw new InvalidTeperatureException(value);
            }
            Value = value;
        }
        public static implicit operator double(Temperature value)
            => value.Value;

        public static implicit operator Temperature(double value)
            => new(value);
    }
}
