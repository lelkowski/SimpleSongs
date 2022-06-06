using Database.Context.Seeders;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Context
{
    public class SongsContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=SimpleSongs;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedDatabase();
        }
    }
}
