using AuthenticationApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationApp.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
