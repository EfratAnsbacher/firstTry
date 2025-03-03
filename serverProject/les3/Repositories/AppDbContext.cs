using les3.Models;
using Microsoft.EntityFrameworkCore;


namespace les3.Repositories
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
