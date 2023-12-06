using Playground.Data.Entities;

namespace Playground.Domain.Repositories
{
    public class AuthorRepo : ListRepository<Author>
    {
        public Author GetAuthorById(int authorId)
           => _items.Find(a => a.Id == authorId);
    }
}
