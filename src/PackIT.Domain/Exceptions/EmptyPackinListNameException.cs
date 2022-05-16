using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackinListNameException : PackITException
    {
        public EmptyPackinListNameException() : base("packing list name is cannot be empty.")
        {

        }
    }
}
