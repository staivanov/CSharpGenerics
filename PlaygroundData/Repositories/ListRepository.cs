using Playground.Domain.Services;

namespace Playground.Domain.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : IEntity
    {
        protected List<T> _items = new();

        public IEnumerable<T> GetAll()
            => _items.ToList();

        public void Add(T item)
            => _items.Add(item);

        public void AddRange(List<T> items)
            => _items.AddRange(items);

        public T GetElementById(int id)
            => _items.Single(i => i.Id == id);

        public void Remove(T item)
            => _items.Remove(item);

        public void Save()
        {
            //No need to be implemented.
        }
    }
}
