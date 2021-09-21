/* Luisalberto Castaneda
 * ITSE 1430
 * Adventurre Game
 * Fall 2020
 */

using System;

namespace LuisCastaneda.AdventureGame.ConsoleHost
{
    internal class Program
    {
        static string s_direction;        
        public static int s_roomNumber = 1;

        private static void Main()
        {
            introduction();
            var exit = false;
            do
            {
                var input = promptUserInput("What will you do? ").ToUpper();
                switch(input)
                {
                    case "MOVE":
                    {
                        s_roomNumber = DirectionAcquisition("Which direction do you want to move? ");
                        SetRoom(s_roomNumber);
                        break;
                    }
                    case "EXAMINE": SetRoom(s_roomNumber); break;
                    case "QUIT": exit = HandleExit(); break;
                    default : HandleError("invalid input"); break;
                }
            } while (!exit);
        }

        private static void SetRoom ( int s_roomNumber )
        {
            switch (s_roomNumber)
            {
                case 0: HandleError("invalid input"); break;
                case 1: room1(); break;
                case 2: room2(); break;
                case 3: room3(); break;
                case 4: room4(); break;
                case 5: room5(); break;
                case 6: room6(); break;
                case 7: room7(); break;
                case 8: room8(); break;
                case 9: room9(); break;
            };
        }

        private static string promptUserInput ( string message )
        {
            Console.Write(message);
            var command = Console.ReadLine().Trim().ToUpper();
            while (command == "HELP")
            {
                help();
                Console.Write(message);
                command = Console.ReadLine().Trim();
            }
            return command;
        }

        private static bool HandleExit () => ReadBoolean("Are you sure you want to quit (Y/N)?");

        private static bool ReadBoolean ( string message )
        {
            Console.Write(message);
            do
            {
                var input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Y)
                    return true;
                else if (input.Key == ConsoleKey.N)
                    Console.WriteLine("");
                    return false;

            } while (true);
        }

        private static int DirectionAcquisition ( string message )
        {
            
            do
            {
                Console.Write(message);
                s_direction = Console.ReadLine().Trim().ToUpper();

                switch(s_direction)
                {
                    case "UP" : return HandleUp();
                    case "DOWN": return HandleDown();
                    case "LEFT": return HandleLeft();
                    case "RIGHT": return HandleRight();
                    default : HandleError("Invalid Input"); break;
                }
            } while (true);
            //return s_roomNumber = 1;

            
        }

        private static int HandleUp ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 4 : return s_roomNumber = 1;
                    case 5 : return s_roomNumber = 2;
                    case 6 : return s_roomNumber = 3;
                    case 7 : return s_roomNumber = 4;
                    case 8 : return s_roomNumber = 5;
                    case 9 : return s_roomNumber = 6;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static int HandleDown ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 1: return s_roomNumber = 4;
                    case 2: return s_roomNumber = 5;
                    case 3: return s_roomNumber = 6;
                    case 4: return s_roomNumber = 7;
                    case 5: return s_roomNumber = 8;
                    case 6: return s_roomNumber = 9;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static int HandleLeft ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 2: return s_roomNumber = 1;
                    case 3: return s_roomNumber = 2;
                    case 5: return s_roomNumber = 4;
                    case 6: return s_roomNumber = 5;
                    case 8: return s_roomNumber = 7;
                    case 9: return s_roomNumber = 8;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static int HandleRight ()
        {
            do
            {
                switch (s_roomNumber)
                {
                    case 1: return s_roomNumber = 2;
                    case 2: return s_roomNumber = 3;
                    case 4: return s_roomNumber = 5;
                    case 5: return s_roomNumber = 6;
                    case 7: return s_roomNumber = 8;
                    case 8: return s_roomNumber = 9;
                    default: HandleError("invalid input"); return s_roomNumber;
                }

            } while (true);
        }

        private static void HandleError ( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void introduction ()
        {
            Console.WriteLine("ITSE 1430, Luisalberto Castaneda, Adventure Game, Fall 2020");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room1 ()
        {
            Console.WriteLine("1");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room2 ()
        {
            Console.WriteLine("2");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room3 ()
        {
            Console.WriteLine("3");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room4 ()
        {
            Console.WriteLine("4");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room5 ()
        {
            Console.WriteLine("5");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room6 ()
        {
            Console.WriteLine("6");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room7 ()
        {
            Console.WriteLine("7");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room8 ()
        {
            Console.WriteLine("8");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void room9 ()
        {
            Console.WriteLine("9");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static void help ()
        {
            Console.WriteLine("Valid Move inputs : Right | Left | Forward | Backward");
            Console.WriteLine("Examine :: ReShows what room your in");
            Console.WriteLine("Help :: Get Help");
            Console.WriteLine("Quit :: Quit the Program");
        }
    }
}
