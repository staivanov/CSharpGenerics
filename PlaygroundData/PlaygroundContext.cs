using Microsoft.EntityFrameworkCore;
using Playground.Data.Entities;

namespace Playground.Data
{
    public class PlaygroundContext : DbContext
    {
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("PlaygroundDb");     
        }
    }
}