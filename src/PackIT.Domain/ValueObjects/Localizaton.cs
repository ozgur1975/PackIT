using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.ValueObjects
{
    public record Localizaton(string City, string Country)
    {
        public static Localizaton Create(string value)
        {
            var splitlocal = value.Split(",");
            return new Localizaton(splitlocal.First(), splitlocal.Last());
        }

        public override string ToString() => $"{City}, {Country}";

    }
}
