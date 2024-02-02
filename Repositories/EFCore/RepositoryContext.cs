using Entities;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Repositories.EFCore
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> opts) : base(opts)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Language> Languages{ get; set; }
        public DbSet<Book> Books{ get; set; }
    }
}
