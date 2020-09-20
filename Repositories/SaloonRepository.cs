using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class SaloonRepository : GenericRepository<Saloon>
    {
        public SaloonRepository (CinemaFestivalDbContext context) : base(context)
        {

        }
        public Saloon GetSaloonByMovieTitle(string movieTitle)
        {

            return context.Saloons.Where(s => s.Movie.Title == movieTitle).FirstOrDefault();
        }
        
        
        
    }
}
