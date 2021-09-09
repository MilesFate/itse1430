﻿// Luisalberto Castaneda
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

            do
            {
                char choice = GetInput();
                if (choice == 'Q')
                    done = HandleQuit();
                else if (choice == 'A')
                    AddMovie();
                else if (choice == 'V')
                    ViewMovie();
                else if (choice == 'D')
                    DeleteMovie();
                else
                    Console.WriteLine("Unknown Option");
                
            } while (!done);
        }

        private static void DeleteMovie ()
        {
            // Confirm
            if (!ReadBoolean("Are you sure (Y/N)? "))
                return;

            //TODO: Delete Movie
            Console.WriteLine("Not implemented");
        }

        static void ViewMovie()
        {
            // TODO: what if they haven't added one yet?
            // TODO: Formatting
            Console.WriteLine(title);
            Console.WriteLine(releaseYear);
            Console.WriteLine(runLength);
            Console.WriteLine(rating);
            Console.WriteLine(isClassic);
            Console.WriteLine(description);
        }

        static string title;
        static string description;
        static int runLength;
        static int releaseYear;
        static double reviewRating;
        static string rating;
        static bool isClassic;

        private static void AddMovie ()
        {
            title = ReadString("Enter the movie title: ",true); // requires
            description = ReadString("Enter the optional description: ",false); // optional

            runLength = ReadInt32("Enter Run Length (in Minutes): ",0); // optional, in minutes, >=0
            releaseYear = ReadInt32("Enter the release year (min 1900): ",1900); // 1900+

            // double reviewRating; // optional, 0.0 to 5.0
            rating= ReadString("Enter the MPAA rating: ",false); // optional, MPAA (not enforced)
            isClassic = ReadBoolean("Is this a classic (Y/N)? "); // optional
        }

        private static int ReadInt32 ( string message, int minimumvalue )
        {
            Console.Write(message);
            do
            {
                // string input = Console.ReadLine();
                var input = Console.ReadLine();

                // int result = Int32.Parse(input);  // crashes program, not good for input
                // int result;

                // if string parsed AND result at least min value
                // if (Int32.TryParse(input, out result))
                //   if (result >= minimumvalue)
                if (Int32.TryParse(input, out var result) && result >= minimumvalue)
                    return result;

                DisplayError("The Value must be an intergal value >= " + minimumvalue);
            } while (true);
            // return -1;
        }

        private static string ReadString ( string message, bool required )
        {
            Console.Write(message);

            do
            {
                // TODO: required, normalize

                string input = Console.ReadLine();
                return input;
            } while (true);
            
        }

        static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
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
            do
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Y)
                    return true;
                else if (input.Key == ConsoleKey.N)
                    return false;

                
            } while (true);

            // not needed anymore
            // return false;
        }

        static char GetInput ()
        {
            Console.WriteLine("Movie Libary");
            Console.WriteLine("------------");

            Console.WriteLine("A) dd");
            Console.WriteLine("V) iew");
            Console.WriteLine("D) elete");
            Console.WriteLine("Q) uit");

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Q")
                    return 'Q';
                else if (input == "A")
                    return 'A';
                else if (input == "V")
                    return 'V';
                else if (input == "D")
                    return 'D';
                DisplayError("invalid input");
            }
            // return default(char);
        }
    }
}
