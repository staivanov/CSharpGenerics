﻿using Playground.Data.Repositories;
using Playground.Data.Entities;
using Playground.Data;
using Playground.Domain.Services;
using Playground.Domain.Repositories;
using Playground.Data.Services;

namespace GenericsPlayground
{
    public class Program
    {
        private static PlaygroundContext _context = new();
        private static IRepository<Author> sqlRepo = new SQLRepository<Author>(_context);
        private static IRepository<Book> listRepo = new ListRepository<Book>();

        static void Main()
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
                    }
                },
            };

            List<Book> myBoks = new()
                    {
                        new() {Id = 1, Title = "Book1", Description = "Loren ipsum"},
                        new() {Id = 2, Title = "Book2", Description = "Triplinin "},
                        new() {Id = 3, Title = "Book3", Description = "Asgardaqwe"},
                    };

            //InsertIntoDb(authors);

            AddBatch(listRepo, myBoks.ToArray());
            PrintAllItemsOnConsole(listRepo);

        }

        public static void PrintAllItemsOnConsole(IRepository<Book> repository)
        {
            var books = repository.GetAll();

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public static Author GetAuthorById(int id)
        {
            return sqlRepo.GetElementById(id);
        }

        public static void InsertIntoDb(List<Author> authors)
        {
            foreach (Author author in authors)
            {
                sqlRepo.Add(author);
            }
            sqlRepo.Save();
        }

        public static void AddBatch<T>(IWriteRepository<T> repository, T[] items)
        {
            foreach (var item in items)
            {
                repository.Add(item);
            }

            repository.Save();
        }
    }
}
