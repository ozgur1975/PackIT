using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class EmptyPackingListIdException : PackITException
    {
        public EmptyPackingListIdException(): base("Packing list ID cannot be empty.")
        {

        }
    }
}
