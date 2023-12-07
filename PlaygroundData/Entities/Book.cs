namespace Playground.Data.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public Book(int id, string name, string description)
            : base(id)
        {
            Name = name;
            Description = description;
        }
    }
}
