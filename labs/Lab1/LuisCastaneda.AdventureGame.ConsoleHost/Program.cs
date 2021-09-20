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
        public static int s_positionX = 0;
        public static int s_positionY = 0;
        private static readonly int s_roomNumber;

        /* TODO: 
         * if(input == "up)
         *      if(roomNum == 1)
         *          error
         */

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
                        s_direction = DirectionAcquisition("Which direction do you want to move? ");
                        MovePlayer(s_direction);
                        SetRoom(s_roomNumber);
                        break;
                    }
                    case "QUIT": exit = HandleExit(); break;
                }
            } while (!exit);
        }

        private static void SetRoom ( int s_roomNumber )
        {
            switch (s_roomNumber)
            {
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

        private static string DirectionAcquisition ( string message )
        {
            do
            {
                int newX , newY ;
                Console.Write(message);

                do
                {
                    newX = s_positionX;
                    newY = s_positionY;
                    s_direction = Console.ReadLine().Trim().ToUpper();
                    
                    if (s_direction == "UP" && -- newY < -2)
                        HandleError("Invalid Input");
                    else if (s_direction == "DOWN" && ++ newY > 0)
                        HandleError("Invalid Input");
                    else if (s_direction == "RIGHT" && ++ newX > 2)
                        HandleError("Invalid Input");
                    else if (s_direction == "LEFT" && -- newX < 0)
                        HandleError("Invalid Input");
                } while (newY < -2 || newY > 0 || newX < 0 || newX > 2);
                return s_direction;

            } while (true);
        }

        static void MovePlayer ( string s_direction )
        {
            switch (s_direction)
            {
                case "UP": s_positionY += 1; break;
                case "DOWN": s_positionY -= 1; break;
                case "LEFT": s_positionX -= 1; break;
                case "RIGHT": s_positionX += 1; break;
                default: HandleError("Invalid Input"); break;
            }
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
            Console.WriteLine("Help :: Get Help");
            Console.WriteLine("Quit :: Quit the Program");
        }
    }
}
