using Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day1.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
