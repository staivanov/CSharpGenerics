namespace Playground.Data.Entities
{
    public class Author : BaseEntity, IComparable<Author>
    {
        private static int authorCounter = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }

        public Author(int id, string firstName, string lastName)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            authorCounter++;
        }

        public Author()
        {
            authorCounter++;
        }

        public override string ToString()
            => $"Id: {Id}, Author full name: {FirstName} {LastName}";


        //Strong typing because of generic interface.
        public int CompareTo(Author? other)
        {
            if (other is null) return 1;

            if(FirstName == other.FirstName)
            {
                return LastName.CompareTo(other.LastName);
            }

            return  FirstName.CompareTo(other.FirstName);
        }
    }
}
