using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data
{
    public abstract class MovieDatabase : IMovieDatabase
    {
        public Movie Add( Movie movie)
        {
            //Check for null
            movie = movie ?? throw new ArgumentNullException(nameof(movie));

            //Validate movie using IValidateObject
            movie.Validate();

            //Verify unique movie
            var existing = GetMovieByNameCore(movie.Title);
            if (existing != null)
                throw new Exception("Movie already exists");

            
            return AddCore(movie);
        }
       
        public IEnumerable<Movie> GetAll()
        {
            return from p in GetAllCore()
                   orderby p.Title, p.Id descending
                   select p;
        }

        public void Remove( int id )
        {
            //Remove
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0");

            RemoveCore(id);
        }

        public Movie Update( Movie movie)
        {
            
            //Check for null
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            movie.Validate();

            //Verify unique movie
            var existing = GetMovieByNameCore(movie.Title);
            if (existing != null && existing.Id != movie.Id)
                throw new Exception("Movie already exists");

            //Find existing
            existing = existing ?? GetCore(movie.Id);
            if (existing == null)
                throw new ArgumentException("Movie not found", nameof(movie));

            return UpdateCore(movie);
        }

        protected abstract Movie AddCore( Movie movie );
        protected abstract IEnumerable<Movie> GetAllCore();
        protected abstract Movie GetCore( int id );
        protected abstract void RemoveCore( int id );
        protected abstract Movie UpdateCore( Movie movie );
        protected abstract Movie GetMovieByNameCore( string title );

    }
}
