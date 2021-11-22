// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;
using System.Collections.Generic;

namespace LuisalbertoCastaneda.AdventureGame
{
    class Inventory
    {
        private List<Item> _items = new List<Item>();

        public Item Add ( Item item, out string error )
        {
            error = item.Validator();
            if (!String.IsNullOrEmpty(error))
                return null;

            var existing = FindItemName(item.ItemName);
            if (existing != null)
            {
                error = "Each room must have a unique name.";
                return null;
            }

            var newItem = item.Creation();

            item.ItemId = newItem.ItemId;

            _items.Add(newItem);

            return item;
        }

        private Item FindItemName( string name )
        {
            foreach (var item in _items)
            {
                if (String.Compare(name, item.ItemName, true) == 0)
                    return item;
            };

            return null;
        }

        private Item FindItemId ( int id )
        {
            foreach (var item in _items)
            {
                if (item.ItemId == id)
                    return item;
            };

            return null;
        }

        public Item Get ( int id )
        {
            var item = FindItemId(id);

            return item?.Creation();
        }

        public IEnumerable<Item> GetAll ()
        {
            foreach (var item in _items)
                yield return item.Creation();
        }
    }
}
