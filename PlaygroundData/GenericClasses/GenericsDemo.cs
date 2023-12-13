namespace Playground.Data.GenericClasses
{
    public class GenericsDemo
    {

    }

    class BaseClass { }

    class BaseClassGeneric<T> { }

    class ResultFromBase<T> : BaseClass { }

    class ResultFromBaseGenericConcrete<T> : BaseClassGeneric<string> { }

    class ResultFromGenericOpen<T> : BaseClassGeneric<Task> { }

    class ConcreteBaseClass : BaseClassGeneric<double> { }

    class GenericPlusClosed<TKey, TValue> { }

    class GenericClassFromGenericPlusClosed<T> : GenericPlusClosed<T, int> { }

    //Concrete classes can't inherit from Generic<T> classes.




}
