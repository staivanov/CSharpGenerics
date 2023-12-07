using Playground.Data.Entities;
using Playground.Domain.Services;

namespace Playground.Data.Services
{   //Demo for non-generic interface inherit generic interface, but can't inherit generic interface with type constrain.
    public interface IAuthorRepository : IRepository<Author>
    {
        public bool IsAuthorExist(Author author);
        public new void AddRange(List<Author> items);
        public new void Add(Author item);
        public new void Remove(Author item);
        public new void Save();
    }
}
