using Playground.Data.Services;

namespace Playground.Domain.Services
{
    public interface IRepository<T> : IWriteRepository<T>, IReadRepository<T> where T : IEntity
    {
      
    }
}
