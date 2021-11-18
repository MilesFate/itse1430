using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MovieLibrary.Sql
{
    public class SqlMovieDatabase : MovieDatabase
    {
        public SqlMovieDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;
        protected override Movie AddCore ( Movie movie )
        {
            var conn = OpenConnetion();

            var cmd = new SqlCommand("AddMovie",conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            /*
             * FOR ALL THAT IS HOLY
             * AND FOR IN THE NAME OF THE EMPOROER 
             * DO NOT ALLOW SQL INJECTIONS
             */

            // Add Parameters
            var parmName = new SqlParameter("@name", System.Data.SqlDbType.VarChar) {
                Value = movie.Title,
            };

            // Approach 2
            cmd.Parameters.Add(parmName);
            var parmRating = cmd.CreateParameter();
            parmRating.ParameterName = "@rating";
            parmRating.SqlDbType = System.Data.SqlDbType.VarChar;
            parmRating.Value = movie.Rating;
            cmd.Parameters.Add(parmRating);

            // Approach 3 !!! ONLY WORKS WITH SQL   
            cmd.Parameters.AddWithValue("@description", movie.Description);
            cmd.Parameters.AddWithValue("@releaseYear", movie.ReleaseYear);
            cmd.Parameters.AddWithValue("@runLength", movie.RunLength);
            cmd.Parameters.AddWithValue("@isClassic", movie.IsClassic);

            object result = cmd.ExecuteScalar();
            
            return movie;
        }
        protected override void DeleteCore ( int id ) => throw new NotImplementedException();
        protected override Movie FindById ( int id ) => GetCore(id);
        protected override Movie FindByTitle ( string title ) => null;
        protected override IEnumerable<Movie> GetAllCore () => Enumerable.Empty<Movie>();
        protected override Movie GetCore ( int id ) => null;
        protected override void UpdateCore ( int id, Movie movie ) => throw new NotImplementedException();

        private SqlConnection OpenConnetion ()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
