using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class SeatRepository : GenericRepository<Seat>
    {
        public SeatRepository(CinemaFestivalDbContext context) : base(context)
        {
        }
        public List<Seat> GetSeatsInSaloon(Saloon saloon)
        {
            return context.Seats.Where(s => s.Saloon.SaloonId == saloon.SaloonId).ToList();
        }
        public Seat GetSeatBySaloonAndSeatIndex(Saloon saloon, int index)
        {
            foreach (var seat in saloon.Seats)
            {
                if (seat.Index() == index)
                    return seat;
            }

            return null;
        } 
        
        
    }
}
