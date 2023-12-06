using Playground.Domain.Services;

namespace Playground.Domain.Repositories
{
    public class ListRepository<T> : IRepository<T>
    {
        protected List<T> _items = new();


        public void Add(T item)
        {      
            _items.Add(item);
        }


        public void Remove(T item)
        {
            _items.Remove(item);
        }


        public void Display()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
