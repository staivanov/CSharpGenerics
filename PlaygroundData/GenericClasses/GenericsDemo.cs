namespace Playground.Data.GenericClasses
{   //Every class must be in a separated file, but this is only for demo purposes.
    public class GenericsDemo
    {

    }

    public class BaseClass
    {
        public static int GlobalCounter { get; set; } = 0;
        public int LocalCounter { get; set; } = 0;
    }

    public class BaseClassGeneric<T> : BaseClass
    {
        public BaseClassGeneric()
        {
            GlobalCounter += 1;
        }
    }

    public class ResultFromBase<T> : BaseClass { }

    public class ResultFromBaseGenericConcrete<T> : BaseClassGeneric<string> { }

    public class ResultFromGenericOpen<T> : BaseClassGeneric<T> { }

    public class ConcreteBaseClass : BaseClassGeneric<double> { }

    public class GenericPlusClosed<TKey, TValue> { }

    public class GenericClassFromGenericPlusClosed<T> : GenericPlusClosed<T, int> { }

    //Concrete classes can't inherit from Generic<T> classes.

}
