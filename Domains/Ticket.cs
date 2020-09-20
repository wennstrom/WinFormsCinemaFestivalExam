using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaClassLibrary
{
    public class Ticket
    {
        public Ticket () { }
        public Ticket(int customerId, decimal price, bool wheelchair, int screeningId, int seatId)
        {
            CustomerId = customerId;
            Price = price;
            Wheelchair = wheelchair;
            ScreeningId = screeningId;
            SeatId = seatId;
            
        }
        [Key]
        public int TicketId { get; private set; }      
        public decimal Price { get; set; }
        public bool Wheelchair { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int ScreeningId { get; set; }
        public virtual Screening Screening { get; set; }
        public int SeatId { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
