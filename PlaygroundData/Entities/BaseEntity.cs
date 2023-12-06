using Playground.Domain.Services;

namespace Playground.Data.Entities
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }

        public BaseEntity()
        {
            
        }

        public BaseEntity(int id)
        {
            Id = id;
        }

     
    }
}
