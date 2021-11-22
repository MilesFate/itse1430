// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

using CharacterCreator;

using LuisalbertoCastaneda.AdventureGame;

namespace LuisalbertoCastaned.AdventureGame
{
    public class Player
    {
        public Player ()
        {
            var playerChatacer = new Character()?.repPlayer();
            var playerInventory = new Inventory();
        }

        public int placeX { get; set; }
        public int placeY { get; set; }
        
        public const int MaximumX = 3;
        public const int MaximumY = 3;
    }
}
