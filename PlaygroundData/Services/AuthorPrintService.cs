using Playground.Data.Entities;

namespace Playground.Data.Services
{
    public class AuthorPrintService
    {
        public AuthorPrintService()
        {

        }


        public void PrintAuthors()
        {
            List<Author> authors = DataSeed.GetAuthors();

            Array.Sort(authors.ToArray());

            foreach (var author in authors)
            {
                Console.WriteLine(author);
            }
        }
    }
}
