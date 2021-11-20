// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;
using System.Collections.Generic;

namespace LuisalbertoCastaneda.AdventureGame
{
    public class World
    {
        public World ()
        {
            var roomCollection = new[] {
                (new Area(){
                    RoomName = "Introduction",
                    RoomId = 0,
                    Description = Introdution(),
                    NorthAccess = false,
                    SouthAccess = false,
                    EastAccess = false,
                    WestAccess = false
                }),

                // New coordinate (1,1)
                (new Area() {
                    RoomName = "Room1",
                    RoomId = 1,
                    Description = Room1(),
                    NorthAccess = false,
                    SouthAccess = true,
                    EastAccess  = true,
                    WestAccess  = false
                }),

                // New coordinate (2,1)
                (new Area() {
                    RoomName = "Room2",
                    RoomId = 2,
                    Description = Room2(),
                    NorthAccess = false,
                    SouthAccess = true,
                    EastAccess  = true,
                    WestAccess  = true
                }),

                // New coordinate (3,1)
                (new Area() {
                    RoomName = "Room3",
                    RoomId = 3,
                    Description = Room3(),
                    NorthAccess = false,
                    SouthAccess = true,
                    EastAccess  = false,
                    WestAccess  = true
                }),

                // New coordinate (1,2)
                (new Area() {
                    RoomName = "Room4",
                    RoomId = 4,
                    Description = Room4(),
                    NorthAccess = true,
                    SouthAccess = true,
                    EastAccess  = true,
                    WestAccess  = false
                }),

                (new Area() {
                    RoomName = "Room5",
                    RoomId = 5,
                    Description = Room5(),
                    NorthAccess = true,
                    SouthAccess = true,
                    EastAccess  = true,
                    WestAccess  = true
                }),

                (new Area() {
                    RoomName = "Room6",
                    RoomId = 6,
                    Description = Room6(),
                    NorthAccess = true,
                    SouthAccess = true,
                    EastAccess  = false,
                    WestAccess  = true
                }),

                (new Area() {
                    RoomName = "Room7",
                    RoomId = 7,
                    Description = Room7(),
                    NorthAccess = true,
                    SouthAccess = false,
                    EastAccess  = true,
                    WestAccess  = false
                }),

                (new Area() {
                    RoomName = "Room8",
                    RoomId = 8,
                    Description = Room8(),
                    NorthAccess = true,
                    SouthAccess = false,
                    EastAccess  = true,
                    WestAccess  = true
                }),

                (new Area() {
                    RoomName = "Room9",
                    RoomId = 9,
                    Description = Room9(),
                    NorthAccess = true,
                    SouthAccess = false,
                    EastAccess  = false,
                    WestAccess  = true
                }),
            };

            _rooms.AddRange(roomCollection);
        }

        private List<Area> _rooms = new List<Area>();

        public static string Introdution ()
        {
            return  "ITSE 1430, Luisalberto Castaneda, Adventure Game, Fall 2020\n " +
                    "-------------------------------------------------------------\n " +
                    "As you wake from from a deep slumber you find that you are in a strange room. \n" +
                    "Getting off the table you were lying on you keep an eye on the shadows in the room, noticing that they seem... strange. \n" +
                    "Exting from this room leads you to an ally more fit to called a slum then the marvel it was sold as. \n" +
                    "In this rundown crumbling ally you notice a clean, maintained door that seems more unnerving then your current state. \n" +
                    "Entering this door you find that it has swallowed you into an abyss. \n" +
                    "Regaining sight, you scan the surroundings only to find that you are in a dim room with a door on each wall.";
        }

        public static string Room1 ()
        {
            return  "After going through the door you feel the atmosphere become more relaxed hearing Kazoo music, feeling like you can lower your guard. \n" +
                    "You approach a bar counter and are handed a water by the bar tender with him softly saying  \"Water is the best drink you could offer someone.\". " +
                    "Looking around you see a man holding a sigh with \"IDK\" printed on it while he whispers \"schwelp\". \n" +
                    "Knowing you need to find an exit, you reluctantly force yourself to leave this safehaven. ";
                }

        public static string Room2 ()
        {
            return "You walk over the cracked bones and stumble into the grand chapel, rows of pews stretching far toward the altar.\n" +
                    "Many of the pews are hacked to splinters, and the carnage of what has happened here begins to become apparent.\n" +
                    "Corpses now decayed and withered are scattered throughout.\n" +
                    "You look around at the horrid display, noticing that most of the bodies are wearing armor.\n" +
                    "Most notably, their uniform is different from yours.\n" +
                    "Those that aren't armored seem to stream into the main aisle toward the altar, going to the South of the chapel.\n" +
                    "There must be a way out in that direction, but there must be answers elsewhere.";
        }

        public static string Room3 ()
        {
            return "Stepping into the room you are met with the sand of a desert, the room seems so vast that you nearly miss the edges of the room.\n" +
                    "In the middle of this artificial landscape you see a statue hidden. \n" +
                    "On this statue is read \" Here lies Bright, the Ruler of Rulers.\". \n" +
                    "Notcing the shadows in the room seem to be too big to fit in the room, you decide you should leave. ";
        }

        public static string Room4 ()
        {
            return "Entering the room there was an instant change in atmosphere, you then hear \"Each room comes in isolation of the others meaning no two rooms are the same.\". \n" +
                    "Seeing the stage so empty made you think of the worlds cruelty, thinking that they deserve a performance of a lifetime. \n" +
                    "As the curtains raise you see that every seat is full, everyone waiting for an encore of the ages. \n" +
                    "After the possession of your body by the Virtuose, the sense of perfection fills your thoughts. \n" +
                    "The curtain lowers and you regain your senses feeling like you gave the audience what they came to see. \n" +
                    "Feeling there is nothing more to do, you feel as if its time to go to another room. ";
        }

        public static string Room5 ()
        {
            return "Upon further examnation of the room it seems as though many have passed into this room before your arrival.\n" +
                    "With the walls looking centries old in some spots and in other seeming to be from a time yet to come it is clear that this new environment holds many secrets. \n" +
                    "The flicker of the candle catches the eye making you wonder \"Who lit the candle?\". \n" +
                    "Regardless of the candles presence, the shadows seem to be too big to fit in the room, they seem to be growing the longer you stay. ";
        }

        public static string Room6 ()
        {
            return "Entering the room there was an instant change in atmosphere, you then hear \"Each room comes in isolation of the others meaning no two rooms are the same.\". \n" +
                    "With the room being lit up by purple lights it gave off a certain feeling.  \n" +
                    "You are then approached by an indian man who then spends hours telling you why should set up a virtual machine for ever website you visit. \n" +
                    "Feeling there is nothing more to do, you feel as if its time to go to another room. ";
        }

        public static string Room7 ()
        {
            return "Entering the room you notice there are three doors, two are freely accessible while the third is blocked by a wall. \n" +
                    "Examining the wall you see it is made of pure diamond, you start to punch it to try and get passed it. \n" +
                    "After punching at the wall for a few hours you think to yourself \"it would take an eternity to get through this wall.\". \n" +
                    "Noticing the shadows in the room seem to be too big to fit in the room, you decide you should leave.  \n";
        }

        public static string Room8 ()
        {
            return "Entering the room there was an instant change in atmosphere, you then hear \"Each room comes in isolation of the others meaning no two rooms are the same.\". \n" +
                    "\"Your eyes deceive you\",\n" +
                    "\"An illusion fools you all\", \n" +
                    " \"Was just a mirror\" \n" +
                    "\"We will die for the sake of the Smith, and in turn, the sake of the Liberator!\"";
        }

        public static string Room9 ()
        {
            return "Upon entering you notice an imideate change. \n" +
                    "It's as if time and space have both stop existing the way you have come to understand them. \n" +
                    "After regaining your composure after what was the greatest shift a body can have, you notice a man leaning against the wall. \n" +
                    "Approaching the man he smiles and says \"What's up broski, I'm Vlad and this is my time!\", you awkwardly wave and look for an exit. \n";
        } 

        private Area FindRoomId ( int id )
        {
            foreach (var room in _rooms)
            {
                if (room.RoomId == id)
                    return room;
            }
            return null;
        }

        public Area Get ( int id )
        {
            var room = FindRoomId(id);
            return room?.Renovate();
        }

        public IEnumerable<Area> GetAll ()
        {
            foreach (var room in _rooms)
                yield return room.Renovate();
        }
    }
}
