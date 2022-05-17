using PackIT.Domain.Const;
using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Factories
{
    public interface IPackingListFactory
    {
        PackingList Create(PackingListId id, PackingListName name, Localizaton localizaton);
        PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, TravelDays days, Gender gender, Localizaton localizaton );
    }
}
