using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLib.Data
{
    public static class MovieDatabaseExtentions
        //Seeding the database
    {
        public static void Seed(this IMovieDatabase source)
        {
            var message = "";
            source.Add(new Movie() {
                Title = "Harry Potter",
                IsOwned = true,
                Length = 60, }, out message);
            source.Add(new Movie() {
                Title = "Star Wars",
                IsOwned = true,
                Length = 120, }, out message);
            source.Add(new Movie() {
                Title = "Planet of the Apes",
                IsOwned = true,
                Length = 140,
            }, out message);
        }
    }
}
