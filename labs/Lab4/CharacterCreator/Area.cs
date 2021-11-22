// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace LuisalbertoCastaneda.AdventureGame
{
    public class Area
    {
        #region Getters and Setters
        public string RoomName
        {
            get => _roomName ?? ""; 
            set => _roomName = (value != null) ? value.Trim() : null; 
        }

        public string Description
        {
            get => _description ?? ""; 
            set => _description = (value != null) ? value.Trim() : null; 
        }

        
        public int RoomId { get; set; }
        public bool NorthAccess { get; set; }
        public bool SouthAccess { get; set; }
        public bool EastAccess { get; set; }
        public bool WestAccess { get; set; }

        #endregion

        private string _roomName;
        private string _description;

        public Area RoomsDef ()
        {
            var room = new Area();

            room.RoomName = RoomName;
            room.Description = Description;
            room.NorthAccess = NorthAccess;
            room.SouthAccess = SouthAccess;
            room.EastAccess = EastAccess;
            room.WestAccess = WestAccess;

            return room;
        }       
    }
}
