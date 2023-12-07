namespace Playground.Data.Entities
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Book> Books { get; set; }

        public Author(int id, string firstName, string lastName)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Author()
        {
            
        }

        public override string ToString()
            => $"Id: {Id}, Author full name: {FirstName} {LastName}";
    }
}
