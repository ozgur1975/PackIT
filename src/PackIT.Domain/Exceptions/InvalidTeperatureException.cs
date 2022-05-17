using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class InvalidTeperatureException : PackITException
    {
        public double Value { get; }
        public InvalidTeperatureException(double value) : base($"Value '{value}' is invalid Temprerature") =>Value = value;

    }
}
