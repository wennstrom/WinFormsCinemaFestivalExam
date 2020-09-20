using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class TicketRepository : GenericRepository<Ticket>
    {
        public TicketRepository(CinemaFestivalDbContext context) : base(context)
        {
        }
        
        public List<Ticket> GetTicketsByCustomerSSN(string ssn)
        {
            return context.Tickets.Where(t => t.Customer.SSN == ssn).ToList();
        }
        public List<Ticket> GetTicketsByCustomerToScreening(Customer customer, Screening screening)
        {
            return context.Tickets.Where(t => t.Customer.SSN == customer.SSN && t.Screening.ScreeningId == screening.ScreeningId).ToList();
        }
        public List<Ticket> GetAllTicketsToScreening(int screeningId)
        {         
            return context.Tickets.Where(t => t.ScreeningId == screeningId).ToList();
        }

    }
}
