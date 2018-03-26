using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data
{
    public interface IMovieDatabase
    {
        //Add Movie
        Movie Add( Movie movie, out string message );
        //Get a Movie
        
        //Get all Movie
        IEnumerable<Movie> GetAll();
        //Remove Movie
        void Remove( int id );
        //Update Movie
        Movie Update( Movie movie, out string message );
    }
}
