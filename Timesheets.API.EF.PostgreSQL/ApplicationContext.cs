using Microsoft.EntityFrameworkCore;
using Timesheets.API.EF.PostgreSQL.Models;


namespace Timesheets.API.EF.PostgreSQL
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ApplicationContext(DbContextOptions options):base(options)
        {
             Database.EnsureCreated();  // первое создание базы данных
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Ignore(x => x.Comment);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdbw1;Username=postgres;Password=1212");
        //}
    }
}
