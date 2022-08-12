using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ElectricJob> ElectricJobs { get; set; }
        public DbSet<JobImages> JobImages { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
    }
}