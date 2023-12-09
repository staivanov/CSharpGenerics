namespace Playground.Data.Services
{
    public interface IWriteRepository<in T>
    {
        public void Add(T item);
        public void Remove(T item);
        public void Save();
    }
}
