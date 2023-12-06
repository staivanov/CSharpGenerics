namespace Playground.Domain.Services
{
    public interface IRepository<T>
    {
        public void Add(T item);
        public void Display();
    }
}
