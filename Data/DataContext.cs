using LifeCycleLab.Models;
using Microsoft.EntityFrameworkCore;

namespace LifeCycleLab.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
    }
}
