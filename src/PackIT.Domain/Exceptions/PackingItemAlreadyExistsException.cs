using PackIT.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Exceptions
{
    public class PackingItemAlreadyExistsException : PackITException
    {

        public string ListName { get;}
        public string ItemName { get;}
        public PackingItemAlreadyExistsException(string listName, string itemName) 
            :base($"Packing list: '{listName}' already definet item '{itemName}'")
        {
           ListName = listName;
            ItemName = itemName;

        }
    }
}
