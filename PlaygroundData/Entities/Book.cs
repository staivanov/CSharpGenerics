namespace Playground.Data.Entities
{
    public class Book : BaseEntity
    {
        public Author Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Book(int id, string name, Author author, string description)
            : base(id)
        {
            Name = name;
            Author = author;
            Description = description;
        }
    }
}
