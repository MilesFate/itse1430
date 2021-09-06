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
            Console.WriteLine("Prompt User");
            string userinput = Console.ReadLine();

            return userinput;
        }

        private static void room1 ()
        {
            Console.WriteLine("1");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room2 ()
        {
            Console.WriteLine("2");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room3 ()
        {
            Console.WriteLine("3");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room4 ()
        {
            Console.WriteLine("4");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room5 ()
        {
            Console.WriteLine("5");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room6 ()
        {
            Console.WriteLine("6");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room7 ()
        {
            Console.WriteLine("7");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room8 ()
        {
            Console.WriteLine("8");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void room9 ()
        {
            Console.WriteLine("9");
            Console.Write("Sentence 1");
            Console.Write("Sentence 2");
            Console.Write("Sentence 3");
            Console.WriteLine("Sentence 4");
            promptUserInput();
        }

        private static void help ()
        {
            promptUserInput();
        }
    }
}
