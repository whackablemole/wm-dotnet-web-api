using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Add references for Entities that will be turned into tables in the database
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

    }
}
