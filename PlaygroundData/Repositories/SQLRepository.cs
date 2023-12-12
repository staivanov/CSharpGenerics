using Microsoft.EntityFrameworkCore;
using Playground.Domain.Services;

namespace Playground.Data.Repositories
{
    //public delegate void AddedItem<in T>(T item);

    public class SQLRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly PlaygroundContext _context;      
        private readonly DbSet<T> _dbSet;

        public SQLRepository(PlaygroundContext context) 
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public event EventHandler<T>? AddedItem;

        public IEnumerable<T> GetAll()
            => _dbSet.ToList();

        public T GetElementById(int id)
           => _dbSet.Find(id);

        public void Add(T item)
        {
            _dbSet.Add(item);
            AddedItem?.Invoke(this, item);
        }

        public void AddRange(List<T> items)
            => _dbSet.AddRange(items);

        public void Remove(T item)
           => _dbSet.Remove(item);

        public void Save()
           => _context.SaveChanges();
    }
}
