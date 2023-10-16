using Microsoft.EntityFrameworkCore;
using Domain.Model;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Activity> Activities { get; set; }
    }
}
