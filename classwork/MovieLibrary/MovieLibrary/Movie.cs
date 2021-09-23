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
        public int releaseYear = 1900;
        public double reviewRating;
        public string rating;
        public bool isClassic;

        public const int MinimumreleaseYear = 1900;

        // Methods - provide functionality (functions inside a class)
        //          can refrence fields in method

        /// <summary> Copies the movie. </summary>
        /// <returns> A copy of the movie. </returns>
        public Movie Copy()
        {
            var movie = new Movie();
            movie.title = title;
            movie.description = description;
            movie.runLength = runLength;
            movie.releaseYear = releaseYear;
            movie.reviewRating = reviewRating;
            movie.rating = rating;
            movie.isClassic = isClassic;

            return movie;
        }

        public string Validate(/*Movie this*/)
        {
            // Name is required
            if (String.IsNullOrEmpty(title)) // this.title
                return "Title is required";

            // Run Length  >= 0
            if (runLength < 0)
                return "Run Length must be at least zero";

            // Realse year >= 1900
            if (releaseYear < MinimumreleaseYear)
                return "Release Year must be at least "+MinimumreleaseYear;

            return null;
        }

        private void SetDescriptionToTitle ()
        {
            description = title;
        }

    }
}
