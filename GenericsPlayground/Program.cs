using Playground.Data.Repositories;
using Playground.Data.Entities;
using Playground.Data;
using Playground.Domain.Services;


namespace GenericsPlayground
{
    public class Program
    {
        private static PlaygroundContext _context = new();
        private static IRepository<Author> sqlRepo = new SQLRepository<Author>(_context);


        static void Main()
        {
            List<Author> authors = new()
            {
                new() { Id = 1, FirstName = "Stevne", LastName = "King" },
                new() { Id = 2, FirstName = "Ivan", LastName = "Vazov" },
                new() { Id = 3, FirstName = "Nikola", LastName = "Vaptsarov" },
            };

            InsertIntoDb(authors);
            Author searchedAuthor = GetAuthorById(id: 3);
            Console.WriteLine(searchedAuthor);
        }


        public static Author GetAuthorById(int id)
        {
            return sqlRepo.GetElementById(id);
        }


        public static void InsertIntoDb(List<Author> authors)
        {
            sqlRepo.AddRange(authors);
            sqlRepo.Save();
        }
    }
}
