using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class ScreeningRepository : GenericRepository<Screening>
    {
        public ScreeningRepository(CinemaFestivalDbContext context) : base(context)
        {
        }
        public Screening GetScreeningByMovieTitleAndStarttime(string movieTitle, string starttime)
        {
            return context.Screenings.Where(s => s.Movie.Title == movieTitle && s.StartTime == starttime).FirstOrDefault();
        }
        public List<Screening> GetScreeningsByMovieTitle(string movieTitle)
        {
            return context.Screenings.Where(s => s.Movie.Title == movieTitle).ToList();
        }
        
    }
}
