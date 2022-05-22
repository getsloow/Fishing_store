using Microsoft.EntityFrameworkCore;
using WhatsArt.Models;

namespace WhatsArt.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Chinook");
            }
        }
      */

           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                  .HasOne<User>(s => s.User)
                  .WithMany(g => g.Posts)
                  .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<User>()
                 .HasMany<Post>(s => s.Posts)
                 .WithOne(g => g.User)
                 .HasForeignKey(s => s.UserId);
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}