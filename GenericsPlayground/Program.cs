﻿using Playground.Data.Repositories;
using Playground.Data.Entities;
using Playground.Data;
using Playground.Domain.Services;
using Playground.Domain.Repositories;
using Playground.Data.Services;
using Playground.Data.GenericClasses;

namespace GenericsPlayground
{
    public class Program
    {
        private static readonly PlaygroundContext _context = new();
        //private static readonly AddedItem<Author> _itemAdded = new(AddedAuthor); //delegate pointing to method AddedAuthor();
        private static readonly SQLRepository<Author> sqlRepo = new(_context);
        private static readonly IRepository<Book> listRepo = new ListRepository<Book>();


        static void Main()
        {
            BaseClassGeneric<int> baseGenericInt = new();
            baseGenericInt.LocalCounter += 3;
            BaseClassGeneric<string> baseGenericString = new();
            BaseClassGeneric<string> baseGenericsString2 = new();
            baseGenericString.LocalCounter += 5;
            BaseClass baseClass = new();
            Console.WriteLine($"BaseClassInt local counter : {baseGenericInt.LocalCounter}");
            Console.WriteLine($"BaseClassString  local counter: {baseGenericString.LocalCounter}");
            Console.WriteLine($"Number of base class generic instances: {BaseClass.GlobalCounter}.");


        }

        private static void SqlRepo_AddedItem(object? sender, Author e)
        {
            Console.WriteLine($"Author {e} was added.");
        }

        private static void AddedAuthor(Author author)
        { //Operator 'as' cast to type, if cast isn't successufll return 'null'.
            Console.WriteLine(author);
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

        public static void InsertIntoDb(List <Author> authors)
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
