using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class CustomerRepository : GenericRepository<Customer>
    {       
        public CustomerRepository(CinemaFestivalDbContext context) : base(context)
        {
            
        }
        public Customer GetCustomerBySSN(string ssn)
        {
            return context.Costumers.Where(c => c.SSN == ssn).FirstOrDefault();
        }
        
        
    }
}
