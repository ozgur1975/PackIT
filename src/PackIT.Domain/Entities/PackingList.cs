using PackIT.Domain.Events;
using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Entities
{
    public class PackingList : AggregateRoot<PackingListId>
    {
        public PackingListId Id { get; private set; } 
        private PackingListName _name;
        private Localizaton _localization;



        private readonly LinkedList<PackingItem> _item = new();
        internal PackingList(Guid id, PackingListName name, Localizaton localization, LinkedList<PackingItem> items)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new EmptyPackingListItemException();
            }

            Id = id;
            _name = name;
            _localization = localization;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyexists = _item.Any(i => i.Name == item.Name);
            if (alreadyexists)
            {
                throw new PackingItemAlreadyExistsException(_name, item.Name);
            }

            _item.AddLast(item);
            AddEvent(new PackingItemAdded(this, item));
        }

        public void AddItems (IEnumerable<PackingItem> items)
        {

            foreach (var item  in items)
            {
                AddItem(item);
            }
        }
    }
}
