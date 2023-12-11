using Playground.Data.Entities;

namespace Playground.Data
{
    public static class DataSeed
    {
        public static List<Author> GetAuthors()
        {
            List<Author> authors = new()
            {
                new() { Id = 1, FirstName = "Stevne", LastName = "King" },
                new() { Id = 2, FirstName = "Ivan", LastName = "Vazov" },
                new() { Id = 3, FirstName = "Nikola", LastName = "Vaptsarov" },
                new() {Id = 4, FirstName = "Test", LastName = "Testov",
                    Books = new List<Book>()
                    {
                        new() {Id = 1, Title = "TestBook", Description = "Bla bla bla", AuthorId = 4},
                        new() {Id = 2, Title = "TestBook2", Description = "Tralalala ", AuthorId = 4},
                        new() {Id = 3, Title = "TestBook3", Description = "Kiss kiss kiss", AuthorId = 4},
                    },
                },
                new() { Id = 5, FirstName = "Ivan", LastName = "Hazdhigenov" },
                new() { Id = 6, FirstName = "Thomas", LastName = "Nelson" },
                new() { Id = 7, FirstName = "Kiril", LastName = "Evstratiev" },
                new() { Id = 8, FirstName = "George", LastName = "Phillips" },
                new() { Id = 9, FirstName = "Henrey", LastName = "Willson" },
                new() { Id = 10, FirstName = "Margaret", LastName = "Stevens" },
            };

            return authors;
        }


        public static List<Book> GetBooks()
        {
            List<Book> myBooks = new()
                    {
                        new() {Id = 1, Title = "Book1", Description = "Loren ipsum"},
                        new() {Id = 2, Title = "Book2", Description = "Triplinin "},
                        new() {Id = 3, Title = "Book3", Description = "Asgardaqwe"},
                        new() {Id = 4, Title = "Book4", Description = "Loren ipsum4"},
                        new() {Id = 5, Title = "Book5", Description = "Triplinin5 "},
                        new() {Id = 6, Title = "Book6", Description = "Asgardaqwe6"},
                        new() {Id = 7, Title = "Book7", Description = "Loren ipsum7"},
                        new() {Id = 8, Title = "Book8", Description = "Triplinin 8 "},
                        new() {Id = 9, Title = "Book9", Description = "Asgardaqwe 9"},
                        new() {Id = 10, Title = "Book10", Description = "Asgardaqwe 10"},
                    };

            return myBooks;
        }
    }
}
