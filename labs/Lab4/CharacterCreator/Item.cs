// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace LuisalbertoCastaneda.AdventureGame
{
    class Item
    {
        #region Getters and Setters

        public string ItemName
        {
            get => _itemName ?? "" ; 
            set => _itemName = (value != null) ? value.Trim() : ""; 
        }
        public int CoinValue { get; set; }
        public int Weight { get; set; }
        public int ItemId { get; set; }

        #endregion

        private string _itemName;

        public Item Creation ()
        {
            var item = new Item();

            item.ItemName = ItemName;
            item.CoinValue = CoinValue;
            item.Weight = Weight;

            return item;
        }

        public string ItemValidator ()
        {
            if (String.IsNullOrEmpty(ItemName))
                return "Item must have a name";
            if (CoinValue < 0)
                return "Item must have value 0 or greater";
            if (Weight <= 0)
                return "Item must has weight";
            return null;
        }
    }
}
