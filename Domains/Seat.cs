using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaClassLibrary
{
    public class Seat
    {
        public Seat() { }
        public Seat (int row, int location)
        {
            Row = row;
            Location = location;

        }
        [Key]
        public int SeatId { get; private set; }
        public int Row { get; set; }
        public int Location { get; set; }
        public bool OptionForWheelchair { get; set; }
        public Saloon Saloon { get; set; }
        public override string ToString()
        {
            return $"{Row}:{Location}";
        }
        public int Index()
        {
            if (Row == 1)
                return Location - 1;
            else
                return (Location - 1) + 10;
        }

    }
}
