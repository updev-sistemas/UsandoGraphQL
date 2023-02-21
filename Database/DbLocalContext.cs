using Microsoft.EntityFrameworkCore;
using UsandoGraphQL.Database.Configuration;
using UsandoGraphQL.Entities;

namespace UsandoGraphQL.Database
{
    public class DbLocalContext : DbContext
    {
        public DbLocalContext(DbContextOptions<DbLocalContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.ApplyConfiguration(new CountryConfiguration());
            _ = modelBuilder.ApplyConfiguration(new StateConfiguration());
            _ = modelBuilder.ApplyConfiguration(new CityConfiguration());
        }

        public DbSet<Country>? Countries { get; set; }
        public DbSet<State>? States { get; set; }
        public DbSet<City>? Cities { get; set; }
    }
}
