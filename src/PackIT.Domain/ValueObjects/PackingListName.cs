using PackIT.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.ValueObjects
{
    public record PackingListName
    {
        public string Value { get; } 

        public  PackingListName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new EmptyPackinListNameException();
            }
                Value = value;
        }
        public static implicit operator string(PackingListName name) 
            => name.Value;

        public static implicit operator PackingListName(string name)
            => new(name);
    }

    
}
