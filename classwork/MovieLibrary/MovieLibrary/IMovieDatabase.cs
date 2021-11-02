// ITSE 1430
// Movie Library

namespace MovieLibrary
{
    public interface IMovieDatabase
    {
        // All Members are always public, cannot specify access
        // Only Type memmbers that are not implementation details are allowed
        //  Methods, properties, events
        // The implementation is not provided 
        Movie Add ( Movie movie, out string error );
        void Delete ( int id );
        Movie Get ( int id );
        Movie[] GetAll ();
        string Update ( int id, Movie movie );
    }
}