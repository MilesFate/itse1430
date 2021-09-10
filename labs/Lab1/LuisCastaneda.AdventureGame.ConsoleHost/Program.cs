/* Luisalberto Castaneda
 * ITSE 1430
 * Adventurre Game
 * Fall 2020
 */

using System;

namespace LuisCastaneda.AdventureGame.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            introduction();
            bool exit = false;
            while (exit == false)
            {
                string choice = promptUserInput();
                switch (choice)
                {
                    case "room 1": room1(); break;
                    case "room 2": room2(); break;
                    case "room 3": room3(); break;
                    case "room 4": room4(); break;
                    case "quit": exit = true; break;
                    default: Console.WriteLine("nopey"); break;
                }
            }
        }

        private static void introduction ()
        {
            Console.WriteLine("ITSE 1430, Luisalberto Castaneda, Adventure Game, Fall 2020");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
        }

        private static string promptUserInput ()
        {

            do
            {
                Console.WriteLine("Prompt user");

                string userinput = Console.ReadLine().ToLower();

                if (userinput == "room 1")
                    return "room 1";
                else if (userinput == "room 2")
                    return "room 2";
                else if (userinput == "room 3")
                    return "room 3";
                else if (userinput == "room 4")
                    return "room 4";
                else if (userinput == "room 5")
                    return "room 5";
                else if (userinput == "room 6")
                    return "room 6";
                else if (userinput == "room 7")
                    return "room 7";
                else if (userinput == "room 8")
                    return "room 8";
                else if (userinput == "room 9")
                    return "room 9";
               
                HandleError("Please try again");
            } while (true);
        }

        private static void HandleError ( string message )
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();


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
            Console.WriteLine(" ");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
        }
    }
}
