using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaClassLibrary
{
    public class Customer
    {
        public Customer() { }
        public Customer(string ssn, string firstName, string lastName, string phoneNumber)
        {

            SSN = ssn;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
        [Key]
        public int CustomerID { get; set; }
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public virtual List<Ticket> Tickets { get; set; }

    }
}
