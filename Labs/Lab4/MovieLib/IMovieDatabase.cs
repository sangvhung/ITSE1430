/*
 * ITSE 1430
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib
{
    /// <summary>Provides access to the movie database.</summary>
    public interface IMovieDatabase
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
        Movie Add ( Movie movie );

        /// <summary>Gets a specific movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <returns>The movie, if found.</returns>
        /// <remarks>
        /// <paramref name="id"/> must be greater than or equal to 0.
        /// </remarks>
        Movie Get ( int id );

        /// <summary>Gets all the movies.</summary>
        /// <returns>The list of movies.</returns>
        IEnumerable<Movie> GetAll ();

        /// <summary>Removes a movie.</summary>
        /// <param name="id">The ID of the movie.</param>
        /// <returns><see langword="true"/> if successful or <see langword="false"/> otherwise.</returns>
        /// <remarks>
        /// <paramref name="id"/> must be greater than or equal to 0.
        /// <para />
        /// If the movie does not exist then nothing happens.
        /// </remarks>
        bool Remove ( int id );

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
        Movie Update ( Movie movie );
    }
}
