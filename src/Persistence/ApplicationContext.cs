using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.Entity<Country>().HasData(
           new Country(){Id = 1,Name = "Venezuela"},
           new Country() {Id=2,Name="Chile" }
           );
        }
    }
}
