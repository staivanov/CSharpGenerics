namespace Playground.Data.Services
{
    public interface IReadRepository<out T>
    {
        public IEnumerable<T> GetAll();
        public T GetElementById(int id);
    }
}
