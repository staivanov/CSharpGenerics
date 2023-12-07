namespace Playground.Domain.Services
{
    public interface IRepository<T> where T : IEntity
    {
        public IEnumerable<T> GetAll();
        public void Add(T item);
        public void AddRange(List<T> items);
        public T GetElementById(int id);
        public void Remove(T item);
        public void Save();
    }
}
