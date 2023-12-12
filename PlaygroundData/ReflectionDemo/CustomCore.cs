namespace Playground.Data.ReflectionDemo
{
    internal class CustomCore : ICore<Process>
    {
        public void Use(Process input)
        {
            Console.WriteLine($"Process name: {input}");
        }
    }
}
