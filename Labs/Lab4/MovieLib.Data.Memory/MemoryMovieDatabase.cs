/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieLib.Data.Memory
{
    /// <summary>Provides an implementation of <see cref="IMovieDatabase"/> using an in-memory collection.</summary>
    public class MemoryMovieDatabase : IMovieDatabase
    {
        /// <summary>Adds a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The added movie, if successful or <see langword="null"/> otherwise.</returns>
        /// <remarks>
        /// <paramref name="movie"/> cannot be <see langword="null"/>.
        /// <para />
        /// <paramref name="movie"/> must be valid.
        /// <para />
        /// A movie with the same name cannot already exist.
        /// </remarks>
        public Movie Add ( Movie movie )
        {
            if (!ValidateMovie(movie))
                return null;

            //Movie cannot already exist
            var existing = GetByTitle(movie.Title);
            if (existing != null)
                return null;

            //Create the new movie
            var newMovie = Clone(movie);
            newMovie.Id = _id++;
            _movies.Add(newMovie);

            return Clone(newMovie);
        }

        /// <summary>Gets a specific movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <returns>The movie, if found.</returns>
        /// <remarks>
        /// <paramref name="id"/> must be greater than or equal to 0.
        /// </remarks>
        public Movie Get ( int id )
        {
            if (id < 0)
                return null;

            return Clone(GetCore(id));
        }

        /// <summary>Gets all the movies.</summary>
        /// <returns>The list of movies.</returns>
        public IEnumerable<Movie> GetAll ()
        {
            foreach (var movie in _movies)
                yield return Clone(movie);
        }

        /// <summary>Removes a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <returns><see langword="true"/> if successful or <see langword="false"/> otherwise.</returns>
        /// <remarks>
        /// <paramref name="id"/> must be greater than or equal to 0.
        /// <para />
        /// If the movie does not exist then nothing happens.
        /// </remarks>
        public bool Remove ( int id )
        {
            if (id < 0)
                return false;

            var existing = GetCore(id);
            if (existing == null)
                return false;

            _movies.Remove(existing);
            return true;
        }

        /// <summary>Updates a movie.</summary>
        /// <param name="movie">The movie to add.</param>
        /// <returns>The updated movie, if successful or <see langword="null"/> otherwise.</returns>
        /// <remarks>
        /// <paramref name="movie"/> cannot be <see langword="null"/>.
        /// <para />
        /// <paramref name="movie"/> must be valid.
        /// <para />
        /// A movie with the same name cannot already exist.
        /// <para />
        /// The movie must already exist.
        /// </remarks>
        public Movie Update ( Movie movie )
        {
            if (!ValidateMovie(movie))
                return null;

            //Movie must already exist
            var existing = GetCore(movie.Id);
            if (existing == null)
                return null;

            //Movie cannot already exist
            var duplicate = GetByTitle(movie.Title);
            if (duplicate != null && duplicate.Id != movie.Id)
                return null;

            //Copy the new values into the existing movie
            UpdateCore(existing, movie);

            return Clone(existing);
        }

        #region Private Members

        //Copies a movie to a new movie, including the ID
        private Movie Clone ( Movie source )
        {
            if (source == null)
                return null;

            var target = new Movie();

            UpdateCore(target, source);
            target.Id = source.Id;

            return target;
        }        

        private Movie GetByTitle ( string title )
        {
            foreach (var movie in _movies)
            {
                if (String.Compare(movie.Title, title, true) == 0)
                    return movie;
            };

            return null;
        }

        private Movie GetCore ( int id )
        {
            foreach (var movie in _movies)
            {
                if (movie.Id == id)
                    return movie;
            };

            return null;
        }

        //Updates a target with the values from the source, except the ID
        private void UpdateCore ( Movie target, Movie source )
        {
            target.Title = source.Title;
            target.Description = source.Description;
            target.IsOwned = source.IsOwned;
            target.Length = source.Length;
        }

        private bool ValidateMovie ( Movie movie )
        {
            if (movie == null)
                return false;
            
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(movie, new ValidationContext(movie), results))
                return false;

            return true;
        }

        private readonly List<Movie> _movies = new List<Movie>();
        private int _id = 1;
        #endregion
    }
}
