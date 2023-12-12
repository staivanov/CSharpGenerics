using System.Reflection;

namespace Playground.Data.ReflectionDemo
{
    public class ReflectionSample
    {
        public static void Use()
        {
            List<Type> types = new()
            {
                typeof(Request),
                typeof(Response),
                typeof(Core<>),
                typeof(ICore<>),
                typeof(Process),
            };

            //BindingFlags flags = BindingFlags.Public
            // | BindingFlags.Instance | BindingFlags.Static;

            //MethodInfo[] methods = typeof(Core<>).GetMethods(flags);

            Type someSpecificType = typeof(Pipeline<,>).MakeGenericType(types[0], types[1]);
            object? instanceCreated = Activator.CreateInstance(someSpecificType);
            object? returnedTye = instanceCreated.GetType();
        

        }
    }
}
