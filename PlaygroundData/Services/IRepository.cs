using Playground.Data.Services;

namespace Playground.Domain.Services
{
    public interface IRepository<T> : IReadRepository<T> where T : IEntity
    {
        public void AddRange(List<T> items);
        public void Add(T item);
        public void Remove(T item);
        public void Save();
    }
}
