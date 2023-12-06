namespace Playground.Domain.Services
{
    /// <summary>
    /// This data structure can work with any type.
    /// </summary>
    public class MyGenericStack<T>
    {   //With generic T there is no boxing/unboxing and the code is a type-safety.
        private readonly T[] _items;
        private int index = -1;


        public MyGenericStack()
        {
            _items = new T[10];
        }


        public MyGenericStack(T item)
        {
            _items =  new T[10];
            _items[++index] = item;
        }


        public void Push(T item) => _items[++index] = item;

        public T Pop() => _items[index--];

        public int Count() => index;
    }
}
