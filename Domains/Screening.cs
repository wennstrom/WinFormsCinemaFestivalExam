using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class Screening
    {
        public Screening() { }
        [Key]
        public int ScreeningId { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string StartTime { get; set; }
        public int SaloonId { get; set; }
        public Saloon Saloon { get; set; }
        public string ToScreeningInfo()
        {
            return $"{Movie.Title}-{StartTime}";
        }
    }
}
