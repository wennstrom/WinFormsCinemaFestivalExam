using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class Movie
    {
        public Movie() { }
        public Movie(string movieTitle, string description)
        {
            Title = movieTitle;
            Description = description;
        }
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
