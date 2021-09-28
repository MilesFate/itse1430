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
        public int Id { get; private set; }
        public string Title
        {
            // T get_Title()
            get { return (_title != null) ? _title : ""; }

            // Write void set_Title ( string value )
            set { _title = (value != null) ? value.Trim() : null; }
        }
        /// <summary> gets and sets the description </summary>
        public string Description
        {
            get { return (_description != null) ? _description : ""; }
            set { _description = (value != null) ? value.Trim() : null; }
        }
        public string Rating
        {
            get { return (_rating != null) ? _rating : ""; }
            set { _rating = (value != null) ? value.Trim() : null; }
        }
        // Full property Syntax
        //public int RunLength
        //{            
        //    get { return _runLength; }            
        //    set { _runLength = value; }
        //}
        public double ReviewRating { get; set; }
        public int RunLength { get; set; }
        public int ReleaseYear { get; set; } = MinimumreleaseYear;
        public bool IsClassic { get; set; }
        
        // TODO : Fix field casting, don't make public
        // Fields
        // 1. Always camel cased, TODO:for now
        // 2. Should NEVER be public
        // 3. Always zero initalized or can default
        // 4. Cannot initalize to another field's value

        private string _title;
        private string _description;
        //private int _runLength;
        private int _releaseYear = MinimumreleaseYear;
        //private double _reviewRating;
        private string _rating;
        //private bool _isClassic;

        // Field is constant and therefore cannot be changed without recompiling
        public const int MinimumreleaseYear = 1900;

        //public int GetAgeInYears()
        //{
        //    return DateTime.Now.Year - _releaseYear;
        //}

        public int AgeInYears
        {
            get { return DateTime.Now.Year - _releaseYear; }
        }

        //public bool IsBlackAndWhite ()
        //{
        //    return _releaseYear <= 1922;
        //}

        public bool IsBlackAndWhite
        {
            get { return _releaseYear <= 1922; }
        }

        // Methods - provide functionality (functions inside a class)
        //          can refrence fields in method
        //   `this` represents the current instance, always the first parameter (implied)

        /// <summary> Copies the movie. </summary>
        /// <returns> A copy of the movie. </returns>
        public Movie Copy()
        {
            var movie = new Movie();
            movie.Title = Title;
            movie.Description = Description;
            movie.RunLength = RunLength;
            movie.ReleaseYear = ReleaseYear;
            movie.ReviewRating = ReviewRating;
            movie.Rating = Rating;
            movie.IsClassic = IsClassic;

            return movie;
        }

        /// <summary>Validates the object.</summary>
        /// <returns>The error, if any.</returns>
        public string Validate(/*Movie this*/)
        {
            // Name is required
            if (String.IsNullOrEmpty(Title)) // this.title
                return "Title is required";

            // Run Length  >= 0
            if (RunLength < 0)
                return "Run Length must be at least zero";

            // Realse year >= 1900
            if (ReleaseYear < MinimumreleaseYear)
                return "Release Year must be at least "+MinimumreleaseYear;

            return null;
        }

        private void SetDescriptionToTitle ()
        {
            _description = Title;
        }

    }
}
