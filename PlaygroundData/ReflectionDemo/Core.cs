namespace Playground.Data.ReflectionDemo
{
    public class Core<T> : ICore<T>
    {
        public void Use(T input)
        {
            Console.WriteLine($"Generic core of T {input}");
        }
    }
}
