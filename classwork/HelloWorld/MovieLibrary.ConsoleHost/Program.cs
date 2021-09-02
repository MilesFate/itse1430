// Luisalberto Castaneda
// ITSE 1450
// Movie Libary
using System;

namespace MovieLibrary.ConsoleHost
{
    class Program
    {
        static void Main ( string[] args )
        {
            bool done = false;
            char choice = GetInput();
            if (choice == 'Q')
                done = HandleQuit();
            else if (choice == 'A')
                AddMovie();
            else
                Console.WriteLine("Unknown Option");
            //TODO: Handle additional stuff

            // Movie details
            
        }

        private static void AddMovie ()
        {
            string title = ReadString("Enter the movie title: ",true); // requires
            string description = ReadString("Enter the optional description: ",false); // optional

            int runLength = ReadInt32("Enter Run Length (in Minutes): ",0); // optional, in minutes, >=0
            int releaseYear = ReadInt32("Enter the release year (min 1900): ",1900); // 1900+

            double reviewRating; // optional, 0.0 to 5.0
            string rating= ReadString("Enter the MPAA rating: ",false); // optional, MPAA (not enforced)
            bool isClassic; // optional
        }

        private static int ReadInt32 ( string message, int minimumvalue )
        {
            Console.Write(message);

            string input = Console.ReadLine();

            // TODO: Input Validation
            // int result = Int32.Parse(input);  // crashes program, not good for input
            int result;
            if (Int32.TryParse(input, out result))
                return result;
            return -1;
        }

        private static string ReadString ( string message, bool required )
        {
            Console.Write(message);

            // TODO: Input Validation
            string input = Console.ReadLine();

            return input;
        }

        private static bool HandleQuit ()
        {
            // Display a confirmation
            if(ReadBoolean("Are you sure you want to quit (Y/N)?"))
            // return results
                return true;
            return false;
        }

        private static bool ReadBoolean ( string message )
        {
            Console.Write(message);

            ConsoleKeyInfo input = Console.ReadKey();
            if (input.Key == ConsoleKey.Y)
                return true;

            //TODO: Input Validation

            return false;
        }

        static char GetInput ()
        {
            Console.WriteLine("Movie Libary");
            Console.WriteLine("------------");

            Console.WriteLine("A) dd");
            Console.WriteLine("Q) uit");

            // TODO: Input Validation

            string input = Console.ReadLine();
            if (input == "Q")
                return 'Q';
            else if (input == "A")
                return 'A';

            return default(char);
        }
    }
}
