
using Microsoft.EntityFrameworkCore;
using OnionArchitectureGuide.Domain.Entities;

namespace OnionArchitectureGuide.Persistence.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
