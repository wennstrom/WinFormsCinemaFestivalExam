using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class Saloon
    {
        public Saloon() 
        {
        }
        [Key]
        public int SaloonId { get; set; }
        public string Name { get; set; }
        public int? MovieId { get; set; }
        public Movie Movie { get; set; }
        public bool WheelchairRamp { get; set; }
        public virtual List<Screening> Screenings { get; set; } 
        public virtual List<Seat> Seats { get; set; }
       
    }
}
