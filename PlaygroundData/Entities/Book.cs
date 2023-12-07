namespace Playground.Data.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Author Author { get; set; }
        public int AuthorId { get; set; }

        public Book()
        {
            
        }

        public Book(int id, string title, string description)
            : base(id)
        {
            Title = title;
            Description = description;
        }
    }
}
