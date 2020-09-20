using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    //Generic interface that all repositories will implement.
    public interface IRepository<T>
    {
        T Add(T entity);
        T Remove(T entity);
        T Get(int id);

        void SaveChanges();
    }
}
