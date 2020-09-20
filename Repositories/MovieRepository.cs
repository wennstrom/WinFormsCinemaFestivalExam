using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CinemaClassLibrary
{
    public class MovieRepository : GenericRepository<Movie>
    {
        public MovieRepository(CinemaFestivalDbContext context) : base(context)
        {
        }
        
        public Movie GetMovieByTitle(string movieTitle) 
        {
            return context.Movies.Where(m => m.Title == movieTitle).FirstOrDefault();
        }
    }
}
