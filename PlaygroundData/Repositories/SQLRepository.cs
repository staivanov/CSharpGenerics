using Microsoft.EntityFrameworkCore;
using Playground.Domain.Services;

namespace Playground.Data.Repositories
{
    public class SQLRepository<T> where T : class, IEntity
    {
        protected List<T> _items = new();

        public PlaygroundContext _context;
        public DbSet<T> _dbSet { get; set; }

        public SQLRepository(PlaygroundContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public T GetItemById(int id)
           => _dbSet.Find(id);


        public void Add(T item)
           => _dbSet.Add(item);


        public void Remove(T item)
           => _dbSet.Remove(item);



        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
