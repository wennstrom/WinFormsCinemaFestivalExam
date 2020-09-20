using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    //generic repository
    public abstract class GenericRepository<T>
        : IRepository<T> where T : class
    {
        protected readonly CinemaFestivalDbContext context;
        public GenericRepository(CinemaFestivalDbContext context)
        {
            this.context = context;
        }
        public T Add(T entity)
        {
            return context.Set<T>().Add(entity);
        }
        public IList<T>AddRange(IList<T> entities)
        {
            return context.Set<T>().AddRange(entities).ToList();
        }
        public T Get(int id)
        {
            
            return context.Set<T>().Find(id);
        }


        public T Remove(T entity)
        {
            return context.Set<T>().Remove(entity);
        }
        public IList<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
