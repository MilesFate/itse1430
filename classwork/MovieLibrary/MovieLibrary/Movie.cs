using System;

namespace MovieLibrary
{
    // naming rules for class
    // 1. Pascal cased
    // 2. Never prefix with T, C or anything else
    // 3. Noun - because the represent an object/entity in your system

    /// <summary> Represents a movie. </summary>

    public class Movie
    {
        // Fields
        // 1. Always camel cased, TODO:for now
        // 2. Should NEVER be public
        // 3. Always zero initalized or can default
        // 4. Cannot initalize to another field's value

        public string title;
        public string description;
        public int runLength;
        public int releaseYear;
        public double reviewRating;
        public string rating;
        public bool isClassic;
    }
}
