namespace Playground.Data.ReflectionDemo
{
    public class Pipeline<TInput, TOutput> : IPipeline<TInput, TOutput>
         where TInput: BaseRequest
         where TOutput: IDisposable, new()
    {

        public TOutput Act(TInput request)
        {
            TOutput response = new();
            Console.WriteLine($"Request: {request}. Response: {response}.");

            return response;
        }
    }
}
