// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace CharacterCreator
{
    /// <summary>Represents a race/species in the game.</summary>
    public class Race
    {
        public Race ( string name ) => Name = name ?? "";

        public string Name { get; }
    }
}
