﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.ValueObjects
{
    public record PackingItem
    {
        public string Name   { get; }
        public uint Quantity { get;}
        public bool IsPacked { get;}

        public PackingItem(string name, uint qantity, bool isPacked)
        {
            Name = name;
            Quantity = qantity;
            IsPacked = isPacked;
        }

    }
}
