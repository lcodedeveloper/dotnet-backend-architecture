using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Contexts
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Duck> Ducks { get; set; }
    }
}
