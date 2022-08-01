using Microsoft.EntityFrameworkCore;

using ProjectDashboard.Models;

namespace ProjectDashboard.DataContext
{
    public class MainDbContext : DbContext
    {

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public MainDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
