namespace Playground.Data.ReflectionDemo
{
    public interface IPipeline<TInput, TOutput>
        where TInput : BaseRequest
        where TOutput : IDisposable, new()
    {
        public TOutput Act(TInput input);
    }
}
